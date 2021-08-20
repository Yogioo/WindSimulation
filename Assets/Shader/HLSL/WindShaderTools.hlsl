#ifndef WIND_SHADER_TOOLS
    #define WIND_SHADER_TOOLS
    float3 _WindCenter;
    float3 _DivisionSize;
    sampler3D _WindTex;
    
    float3 Wolrd2UV(float3 worldPos)
    {
        return((worldPos - _WindCenter) / _DivisionSize + 1) / 2;
    }
    
    float3 Sample3DWind(float3 worldPos){
        return abs(tex3D(_WindTex, Wolrd2UV(worldPos)).xyz);
    }

    float3 GetWindForce(float3 worldPos)
    {
        float3 c= Sample3DWind(worldPos);
        float3 l= Sample3DWind(worldPos+float3(1,0,0));
        float3 r= Sample3DWind(worldPos-float3(1,0,0));
        float3 t= Sample3DWind(worldPos+float3(0,1,0));
        float3 d= Sample3DWind(worldPos-float3(0,1,0));
        float3 f= Sample3DWind(worldPos+float3(0,0,1));
        float3 b= Sample3DWind(worldPos-float3(0,0,1));
        return (c+l+r+t+d+f+b) / 7.0f;
    }
#endif
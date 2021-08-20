#ifndef WIND_SHADER_TOOLS
    #define WIND_SHADER_TOOLS
    float3 _WindCenter;
    float3 _DivisionSize;
    sampler3D _WindTex;
    
    float3 Wolrd2UV(float3 worldPos)
    {
        return((worldPos - _WindCenter) / _DivisionSize + 1) / 2;
    }
    
    float3 GetWindForce(float3 worldPos)
    {
        return tex3D(_WindTex, Wolrd2UV(worldPos)).xyz;
    }
#endif
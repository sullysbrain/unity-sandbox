Shader "Simple Talk/Wireframe Tutorial"
{
    Properties
    {
        _Color("Color", Color) = (1, 1, 1, 1)
        _Wireframe("Wireframe thickness", Range(0.0, 0.005)) = 0.0025
        _Transparency("Transparency", Range(0.0, 1)) = 0.5
    }
    
    Subshader
    {
        Tags { "Queue" = "Transparent" "RenderType" = "Transparent" }
        LOD 200

        Pass
        {
            Blend SrcAlpha OneMinusSrcAlpha
            Cull Back
            CGPROGRAM
            #pragma vertext vertexFunction
            #pragma fragment fragmentFunction
            #pragma geometry geometryFunction

            struct v2g
            {
                float4 pos : SV_POSITION;
            };
            struct g2f
            {
                float4 pos : SV_POSITION;
                float3 bary : TEXCOORD0;
            }



        }

    }


}
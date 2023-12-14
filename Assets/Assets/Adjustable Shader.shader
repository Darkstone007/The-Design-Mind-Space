Shader "Custom/ColorShader" {
    Properties {
        _Color1 ("Color 1", Color) = (1, 0, 0, 1)
        _Color2 ("Color 2", Color) = (0, 1, 0, 1)
        _Color3 ("Color 3", Color) = (0, 0, 1, 1)
        _Color4 ("Color 4", Color) = (1, 1, 0, 1)
        _Color5 ("Color 5", Color) = (1, 0, 1, 1)
        _Color6 ("Color 6", Color) = (0, 1, 1, 1)
        _Color7 ("Color 7", Color) = (0.5, 0.5, 0.5, 1)
        _Color8 ("Color 8", Color) = (1, 0.5, 0, 1)
        _Color9 ("Color 9", Color) = (0, 0.5, 1, 1)
        _Color10 ("Color 10", Color) = (0.5, 1, 0, 1)
        // Define more color properties as needed
    }

    SubShader {
    Shader "Custom/ColorShader" {
    Properties {
        // Define shader properties here
        // ...
    }

    SubShader {
        Tags { "RenderType"="Opaque" } // Define render type (opaque, transparent, etc.)
        LOD 200 // Level of detail

        // Here, you'd include the actual shader code for rendering the object
        // For example, you might have vertex and fragment shaders
        
        // Vertex shader
        Pass {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            struct appdata {
                float4 vertex : POSITION;
            };

            struct v2f {
                float4 pos : SV_POSITION;
            };

            v2f vert(appdata v) {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                return o;
            }

            fixed4 frag(v2f i) : SV_Target {
                return fixed4(1, 1, 1, 1); // Example fragment shader output
            }
            ENDCG
        }
    }
}


    }
}

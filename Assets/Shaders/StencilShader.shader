Shader "Unlit/StencilShader"
{
    Properties
    {
        [IntRange] _StencilRef ("Stencil Reference Value", Range(0,255)) = 128
    }
    SubShader {
        Tags { "RenderType"="Opaque" "Queue"="Geometry-1" }
        Stencil {
            Ref [_StencilRef]
            Comp Always
            Pass Invert
        }
        Pass {
            Fog { Mode Off }
            Color (0,0,0,0)
            ColorMask 0
        }
    }
}
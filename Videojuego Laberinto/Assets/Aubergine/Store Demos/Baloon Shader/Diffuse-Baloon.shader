Shader "Aubergine/Object/Surf/Sample/Diffuse-Baloon" {
	Properties {
		_MainTex("Base (RGB)", 2D) = "white" {}
		/* BALOON SHADER PROPERTIES */
		_Color("Tint (RGB)", Color) = (1,1,1,1)
		_Cutoff("Alpha Cutoff", Range(0,1)) = 0.5
		_Amount("Baloon Amount", Range(0.0, 1.0)) = 0.1
	}

	SubShader {
		Tags { "RenderType" = "Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma exclude_renderers xbox360 ps3 flash
		#pragma surface surf Lambert

		sampler2D _MainTex;

		struct Input {
			float2 uv_MainTex;
		};

		void surf (Input IN, inout SurfaceOutput o) {
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG

		/* BALOON SHADER PASS */
		UsePass "Aubergine/Object/BaseFX/Baloon/BASE"
	} 

	FallBack "Diffuse"
}
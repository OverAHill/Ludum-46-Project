

// A constant buffer that stores the three basic column-major matrices for composing geometry.
cbuffer ModelViewProjectionConstantBuffer : register(b0)
{
	matrix world;
	matrix view;
	matrix projection;

	float4 diffuseMtrl; //colour vector diffuse material
	float4 diffuseLight; // colour vector diffuse light colour

	float4 ambientMaterial;
	float4 ambientLight;

	float4 specularMtrl;
	float4 specularLight;
	float specularPower;
	float3 eyePosW;

	float3 lightVecW;
};

// Per-vertex data used as input to the vertex shader.
struct VertexShaderInput
{
	float3 pos : POSITION;
	float3 Norm : NORMAL;
	float2 Tex :TEXCOORD0;
};

// Per-pixel color data passed through the pixel shader.
struct PixelShaderInput
{
	float4 pos : SV_POSITION;
	float3 Norm : NORMAL;
	float3 posW : POSITION;
	float2 Tex :TEXCOORD0;
};

// Simple shader to do vertex processing on the GPU.
PixelShaderInput main(VertexShaderInput input)
{
	PixelShaderInput output;
	float4 pos = float4(input.pos, 1.0f);

	//output.Pos = mul(Pos, World);
	output.posW = input.pos;

	// Transform the vertex position into projected space.
	pos = mul(pos, world);
	pos = mul(pos, view);
	pos = mul(pos, projection);

	output.pos = pos;
	output.Norm = mul(float4(NormalL, 0.0f), World).xyz;
	output.tex = input.Tex;

	// Pass the color through without modification.
	output.color = input.color;

	return output;
}

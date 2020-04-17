Texture2D txDiffuse : register(t0);
Texture2D txSpecular : register(t1);
SamplerState samLinear : register(s0);

// Per-pixel color data passed through the pixel shader.
struct PixelShaderInput
{
	float4 pos : SV_POSITION;
	float3 Norm : NORMAL;
	float3 posW : POSITION;
	float2 Tex :TEXCOORD0;
};

// A pass-through function for the (interpolated) color data.
float4 main(PixelShaderInput input) : SV_TARGET
{
	float4 textureColour = txDiffuse.Sample(samLinear, input.Tex);
	float4 textureSpecular = txSpecular.Sample(samLinear, input.Tex);
	clip(textureColour.a - .25f); // clips anything with aplha value of less that a 1/4

	float3 toEye = normalize(EyePosW - input.PosW.xyz);

	float3 normalW = input.Norm;
	normalW = normalize(normalW);

	//compute the reflection vector
	float3 lightVec = normalize(lightVecW);

	float3 r = reflect(-lightVec, normalW);
	//determin how much spec makes it (if any )
	float specularAmount = textureSpecular * pow(max(dot(r, toEye), 0.0f), specularPower);

	//compute ambient lighting
	float3 ambient = (ambientMaterial * ambientLight).rgb;

	//compute specular
	float3 specular = specularAmount * (specularMtrl * specularLight).rgb;

	// Compute Colour using Diffuse lighting only
	float diffuseAmount = max(dot(lightVec, normalW), 0.0f);
	float3 diffuse = diffuseAmount * (diffuseMtrl * diffuseLight).rgb;

	float4 colourOutput;
	colourOutput.rgb = (textureColour * (diffuse + ambient)) + specular;
	colourOutput.w = textureColour.a + diffuseMtrl.a;


	return colourOutput;

	//return float4(input.color, 1.0f);
}

// from here

//Texture2D txDiffuse : register(t0);
//Texture2D txSpecular : register(t1);
//SamplerState samLinear : register(s0);

//cbuffer ConstantBuffer : register(b0) //shader constant
//{
//	matrix World;
//	matrix View;
//	matrix Projection;
//
//	float4 DiffuseMtrl; //colour vector diffuse material
//	float4 DiffuseLight; // colour vector diffuse light colour
//
//	float4 AmbientMaterial;
//	float4 AmbientLight;
//
//	float4 SpecularMtrl;
//	float4 SpecularLight;
//	float SpecularPower;
//	float3 EyePosW;
//
//	float3 LightVecW; //light vector, directional light
//
//	float gTime; //new
//}

////--------------------------------------------------------------------------------------
//struct VS_OUTPUT
//{
//	float4 Pos : SV_POSITION;
//	float3 Norm : NORMAL;
//	float3 PosW : POSITION;
//	float2 Tex : TEXCOORD0;
//};

//--------------------------------------------------------------------------------------
// New Vertex Shader Gouraud shading
//--------------------------------------------------------------------------------------
//VS_OUTPUT VS(float4 Pos : POSITION, float3 NormalL : NORMAL, float2 Tex : TEXCOORD)
//{
//	VS_OUTPUT output = (VS_OUTPUT)0;
//
//	output.Pos = mul(Pos, World);
//
//	output.PosW = output.Pos;
//
//	output.Pos = mul(output.Pos, View);
//	output.Pos = mul(output.Pos, Projection);
//	output.Norm = mul(float4(NormalL, 0.0f), World).xyz;
//	output.Tex = Tex;
//
//	/*output.Pos.xy += 0.5f * sin(Pos.x) * sin(3.0f * gTime);
//	output.Pos.z = 0.6f + 0.4f*sin(2.0f*gTime);*/
//	return output;
//}


//--------------------------------------------------------------------------------------
// Pixel Shader
//--------------------------------------------------------------------------------------
//float4 PS(VS_OUTPUT input) : SV_Target
//{
//	float4 textureColour = txDiffuse.Sample(samLinear, input.Tex);
//	float4 textureSpecular = txSpecular.Sample(samLinear, input.Tex);
//	clip(textureColour.a - .25f); // clips anything with aplha value of less that a 1/4
//
//	float3 toEye = normalize(EyePosW - input.PosW.xyz);
//
//	float3 normalW = input.Norm;
//	normalW = normalize(normalW);
//
//	//compute the reflection vector
//	float3 lightVec = normalize(LightVecW);
//
//	float3 r = reflect(-lightVec, normalW);
//	//determin how much spec makes it (if any )
//	float specularAmount = textureSpecular * pow(max(dot(r, toEye), 0.0f), SpecularPower);
//
//	//compute ambient lighting
//	float3 ambient = (AmbientMaterial * AmbientLight).rgb;
//
//	//compute specular
//	float3 specular = specularAmount * (SpecularMtrl * SpecularLight).rgb;
//
//	// Compute Colour using Diffuse lighting only
//	float diffuseAmount = max(dot(lightVec, normalW), 0.0f);
//	float3 diffuse = diffuseAmount * (DiffuseMtrl * DiffuseLight).rgb;
//
//	float4 colourOutput;
//	colourOutput.rgb = (textureColour * (diffuse + ambient)) + specular;
//	colourOutput.w = textureColour.a + DiffuseMtrl.a;
//
//
//	return colourOutput;
//}
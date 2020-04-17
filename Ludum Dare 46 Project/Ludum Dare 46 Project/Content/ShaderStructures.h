#pragma once

namespace Ludum_Dare_46_Project
{
	// Constant buffer used to send MVP matrices to the vertex shader.
	struct ModelViewProjectionConstantBuffer
	{
		DirectX::XMFLOAT4X4 world;
		DirectX::XMFLOAT4X4 view;
		DirectX::XMFLOAT4X4 projection;

		DirectX::XMFLOAT4 diffuseMaterial;
		DirectX::XMFLOAT4 diffuseLight;

		DirectX::XMFLOAT4 ambientMaterial;
		DirectX::XMFLOAT4 ambientLight;

		DirectX::XMFLOAT4 specularMaterial;
		DirectX::XMFLOAT4 specularLight;
		FLOAT specularPower;
		DirectX::XMFLOAT3 eyePosW;

		DirectX::XMFLOAT3 lightVecW;

	};

	// Used to send per-vertex data to the vertex shader.
	struct VertexPositionColor
	{
		DirectX::XMFLOAT3 pos;
		DirectX::XMFLOAT3 normal;
	};
}
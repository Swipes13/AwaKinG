#pragma once
#include "Entity.h"
#include "../Parser.h"

#define CELL_SPACE 10.0f
#define NUM_VERTS 64
class Terrain {
public:
  string errorMessage;
  static Terrain& getInstance();
  void shutdown();
  bool create(int sizeX, int sizeY);
  float getHeight(float x, float z);
  int getNumTiles();
  int getIndexCount();
  bool getInitialized();
  ID3D11ShaderResourceView** getTexture(int index);
  ID3D11Buffer** getVertexBuffer(int index);
  ID3D11Buffer* getIndexBuffer();
  XMFLOAT4X4* getWorldMatrix();
  bool save(string fileName);
  bool open(string fileName);
private:
  Terrain();
  Terrain(const Terrain&);
  void _generateHeightMap();
  bool _generateGeometry();
  bool _generateTextures();
  bool _createIndexBuffer();

  int   _sizeX;
  int   _sizeY;
  int   _numTiles;
  int   _numVertsInRaw;
  int   _numVertsInCol;
  int   _maxId;

  int	  _numTileVerts;
  int	  _numTileQuads;
  int		_numQuads;
  int		_numIndexs;

  float   _halfSpaceRaw;
  float   _halfSpaceCol;
  XMFLOAT4X4                  _worldMatrix;

  XMFLOAT3*	                  _normalMap;
  XMFLOAT3*	                  _heightMap;
  uint*			                  _indexes;
  int**							          _pickToHeightMap;
  int**							          _heightMapToTiles;

  ID3D11Buffer*								_indexBuffer;
  ID3D11Buffer**							_vertexBuffers;
  ID3D11ShaderResourceView**	_textures;
  string                      _2048dds;
  bool                        _initialized;
};


#pragma once
#include "../Parser.h"
#include "TerrainSector.h"
#include "TerrainPen.h"

struct Quad
{
	int _1; int _2; int _3; int _4;
	int center; float diapazon;

	int leftID; int rightID; int upID; int downID;
	float left; float right; float up; float down;

	int tileId;
};
struct Biom
{
	Biom(float height_, float range_)
	{
		height = height_;
		range = range_;
		halfRange = range_ / 2.0f;
	}
	float height;
	float range;
	float halfRange;
};
class TerrainManager
{
public:
	std::string ErrorMessage;
	TerrainManager();

#pragma region functions
public:
	virtual void shutdown();
	virtual bool loadFromFile(string fileName);
	bool _readVertexBlock(string fileName);

#pragma endregion
protected:
	bool _createIndexBuffer();
	bool _generateGeometry();

protected:
	struct Properties
	{
		Properties(){}
		Properties(int x, int y)
		{
			initialized = true;

			sizeX = x; sizeY = y;
			sizeSectorX = x * 4;
			sizeSectorY = y * 4;
			numTiles = sizeX * sizeY;
			numSectors = numTiles * 16;
			pickToHeightMap = new int*[numTiles];
			sectorsToHeightMap = new int*[numSectors];
			numVertsInRaw = x * numQuad + 1;
			numVertsInCol = y * numQuad + 1;
			maxId = numVertsInRaw * numVertsInCol;
			heightMapToTerrain = new int*[maxId];
			heightMapToSectors = new int*[maxId];
			quadVertConnect = new int[numTileQuads];
			int k = 0;
			for(int i = 0; i < numTileQuads; i++)
			{
				if(i != 0 && i % numQuad == 0)
					k += 1;
				quadVertConnect[i] = i + k;
			}
			for(int i = 0; i < maxId; i++)
			{
				heightMapToTerrain[i] = new int[1];
				heightMapToTerrain[i][0] = 0;
				heightMapToSectors[i] = new int[1];
				heightMapToSectors[i][0] = 0;
			}
			for(int i = 0; i < numTiles; i++)
				pickToHeightMap[i] = new int[numTileVerts];

			for(int i = 0; i < numSectors; i++)
				sectorsToHeightMap[i] = new int[numSectorVerts];

			k = 0;
			int k_raw = 0;
			for(int i = 0; i < numTiles; i++)
			{
				k_raw = 0; 
				int qwer = i % sizeX;
				if(qwer == 0 && i != 0)
					k += numVertsInRaw * numQuad;
				else
					qwer *= numQuad;

				int savedI_ = 0; int savedJ_ = 0; int savedK_ = 0; int savedL_ = 0; int savedM_ = 0; int savedN_ = 0;
				for(int j = 0; j < numTileVerts; j++)
				{
					if(j % numVerts == 0 && j != 0) k_raw += numVertsInRaw - numVerts;

					pickToHeightMap[i][j] = k + qwer + j + k_raw;

					switch(heightMapToTerrain[k + qwer + j + k_raw][0])
					{
					case 0:
						heightMapToTerrain[k + qwer + j + k_raw] = new int[3];
						heightMapToTerrain[k + qwer + j + k_raw][0] = 1;
						heightMapToTerrain[k + qwer + j + k_raw][1] = i;
						heightMapToTerrain[k + qwer + j + k_raw][2] = j;
						break;
					case 1:
						savedI_ = heightMapToTerrain[k + qwer + j + k_raw][1];
						savedJ_ = heightMapToTerrain[k + qwer + j + k_raw][2];

						heightMapToTerrain[k + qwer + j + k_raw] = new int[5];
						heightMapToTerrain[k + qwer + j + k_raw][0] = 2;
						heightMapToTerrain[k + qwer + j + k_raw][1] = savedI_;
						heightMapToTerrain[k + qwer + j + k_raw][2] = savedJ_;
						heightMapToTerrain[k + qwer + j + k_raw][3] = i;
						heightMapToTerrain[k + qwer + j + k_raw][4] = j;
						break;
					case 2:
						savedI_ = heightMapToTerrain[k + qwer + j + k_raw][1];
						savedJ_ = heightMapToTerrain[k + qwer + j + k_raw][2];
						savedK_ = heightMapToTerrain[k + qwer + j + k_raw][3];
						savedL_ = heightMapToTerrain[k + qwer + j + k_raw][4];

						heightMapToTerrain[k + qwer + j + k_raw] = new int[7];
						heightMapToTerrain[k + qwer + j + k_raw][0] = 3;
						heightMapToTerrain[k + qwer + j + k_raw][1] = savedI_;
						heightMapToTerrain[k + qwer + j + k_raw][2] = savedJ_;
						heightMapToTerrain[k + qwer + j + k_raw][3] = savedK_;
						heightMapToTerrain[k + qwer + j + k_raw][4] = savedL_;
						heightMapToTerrain[k + qwer + j + k_raw][5] = i;
						heightMapToTerrain[k + qwer + j + k_raw][6] = j;
						break;
					case 3:
						savedI_ = heightMapToTerrain[k + qwer + j + k_raw][1];
						savedJ_ = heightMapToTerrain[k + qwer + j + k_raw][2];
						savedK_ = heightMapToTerrain[k + qwer + j + k_raw][3];
						savedL_ = heightMapToTerrain[k + qwer + j + k_raw][4];
						savedM_ = heightMapToTerrain[k + qwer + j + k_raw][5];
						savedN_ = heightMapToTerrain[k + qwer + j + k_raw][6];

						heightMapToTerrain[k + qwer + j + k_raw] = new int[9];
						heightMapToTerrain[k + qwer + j + k_raw][0] = 4;
						heightMapToTerrain[k + qwer + j + k_raw][1] = savedI_;
						heightMapToTerrain[k + qwer + j + k_raw][2] = savedJ_;
						heightMapToTerrain[k + qwer + j + k_raw][3] = savedK_;
						heightMapToTerrain[k + qwer + j + k_raw][4] = savedL_;
						heightMapToTerrain[k + qwer + j + k_raw][5] = savedM_;
						heightMapToTerrain[k + qwer + j + k_raw][6] = savedN_;
						heightMapToTerrain[k + qwer + j + k_raw][7] = i;
						heightMapToTerrain[k + qwer + j + k_raw][8] = j;
						break;
					}
				}
			}


			float one_shir = ((float)numQuad) * cellSpace;
			float pol_width = sizeX * one_shir / 2.0f;
			float pol_height = sizeY * one_shir / 2.0f;
			for(int i = 0; i < numVertsInCol; i++)
			{
				for(int j = 0; j < numVertsInRaw; j++)
				{
					heightMap.push_back(
						float3(cellSpace * i - pol_height, 0.0f, cellSpace * j - pol_width));
					normalMap.push_back(float3(0.0f, 1.0f, 0.0f));
				}
			}
		}
		void Release()
		{
			if(initialized)
			{
				heightMap.clear(); normalMap.clear();
				for(int i = 0; i < sectors.size(); i++)
				{
					sectors[i]->release();
					delete sectors[i];
				}
				sectors.clear();
				delete[] pickToHeightMap;
				delete[] sectorsToHeightMap;
				delete[] heightMapToTerrain;
				delete[] heightMapToSectors;
				delete quadVertConnect;
				if(indexes != NULL)
					delete indexes;
			}
		}
		vector<TerrainSector*>	sectors;
		int**										heightMapToSectors;
		int**										sectorsToHeightMap;

		vector<float3>		heightMap;
		vector<float3>		normalMap;
		int**							pickToHeightMap;
		int**							heightMapToTerrain;
		int*							quadVertConnect;
		unsigned int*			indexes = NULL;

		int sizeX;			int sizeSectorX; bool initialized = false;
		int sizeY;			int sizeSectorY; int numVertsInRaw;	int numVertsInCol;
		int numTiles;		int numSectors;
		int maxId;

		float cellSpace = 50.0f;
		int		numVerts = 65;
		int		numTileVerts = numVerts * numVerts;
		int		numQuad = numVerts - 1;
		int		numTileQuads = numQuad * numQuad;
		int		numIndex = numTileQuads * 6;

		int		numSQuads = numQuad / 4;
		int		numSVerts = numSQuads + 1;
		int		numSectorVerts = numSVerts * numSVerts;
		int		numSectorQuads = numSQuads * numSQuads;
	};
	Properties									_props;

	QuadTree*										_quadTree;
	string											_2048Path;
	ID3D11Buffer*								_indexBuffer;
	ID3D11Buffer**							_vertexBuffers;
	ID3D11ShaderResourceView**	_textures;
};
class RedactorTerrainManager : public TerrainManager
{
public:
	RedactorTerrainManager();
	void initialize();
	void shutdown();
	bool generate(int gridX, int gridY);
	bool loadFromFile(string fileName);
	bool saveToFile(string fileName);
	void randomize(int diapazon);
	void diamondSquareAlgorythm();
	void normalizeNormals();
	void blurHeightmap(int blurHard);
	void setTerraPenSize(int in, int out);
	void setTerraPenHard(float hard);
	void setTerraPenSmoothKoeff(float smoothKoeff);

	void terraformShow(precomputeRay* pickRay);
	void terraformApply(precomputeRay* pickRay);
	void terraformApplyPosLock(precomputeRay* pickRay);
	void terraformApplyShiftHeight(precomputeRay* pickRay);
	void terraformApplyAltHard(precomputeRay* pickRay);

	void terraformApplySmIn(precomputeRay* pickRay);
	void terraformApplySmOut(precomputeRay* pickRay);
	void terraformApplySmInOut(precomputeRay* pickRay);

	void textureWork(precomputeRay* pickRay);

	void set2048Path(string path);
	bool hitTerrainSector(QuadTree* tree, precomputeRay* pickRay, QuadTree** hits, int* count, bool* done);

private:
		void _pick(precomputeRay* pickRay, vector<QuadTree*>* rayAabbIntersected);
	int _terraPick(precomputeRay* pickRay, int* terrainId);
	void _setDSQuadProps(Quad* quad, int indexQuad, vector<Quad>* listQuads, Quad* father,
		vector<int>* _1, vector<int>* _2, vector<int>* _3, vector<int>* _6, vector<int>* _11, vector<int>* _22,
		vector<int>* _43, vector<int>* _86, vector<int>* _171, vector<int>* _342);
	bool _vectorConains(vector<int>* vect, int value);
	bool _getQuadIntersectID(TerrainSector* sector, float3* pickDir, float3* pickOrig, int* returnedID);
	bool _getQuadIntersectID(TerrainSector* sector, float3* pickDir, float3* pickOrig, float* tu, float* tv);
	bool _intersectTriangle(float3* pickOrig, float3* pickDir, XMFLOAT3** vs);
	bool _intersectTriangle(float3* pickOrig, float3* pickDir, XMFLOAT3** vs, float* tu, float* tv);

	void _smoothVert(int id);
	void _updateSector(int idSector);
	void _updateVertexBuffer(int idTerrain);
	void _updateSubVertexBuffer(int idTerrain);

	void _terraformShow(int terrainId, int vertId);
	void _terraformApply(int terrainId, int vertId);
	void _terraformApplyPosLock(int terrainId, int vertId);
	void _terraformApplyShiftHeight(int terrainId, int vertId);
	void _terraformApplyAltHard(int terrainId, int vertId);
	void _terraformApplySmIn(int terrainId, int vertId);
	void _terraformApplySmOut(int terrainId, int vertId);
	void _terraformApplySmInOut(int terrainId, int vertId);

	void _renormal(vector<int>* ids, int sizeX);
	void _textureWork(int terrainId, XMFLOAT2 texcoord);

	int4 _getLRUD(int vId, int currentRaw, int size);
	inline int _getLeftTerrainIDValue(int vId, int currentRaw, int size);
	inline int _getRightTerrainIDValue(int vId, int currentRaw, int size);
	inline int _getUpTerrainIDValue(int vId, int size);
	inline int _getDownTerrainIDValue(int vId, int size);
	float _dist(float3 point1, float3 point2);
private:
	vector<Biom>				_bioms;
	TextureTerrainPen*	_texturePen;
	HeightTerrainPen*		_heightPen;

	int**								_vertsToUpdate;
	int*								_countVertToUpdate;
};

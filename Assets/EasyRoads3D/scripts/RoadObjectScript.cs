using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using System;
using EasyRoads3D;

public class RoadObjectScript : MonoBehaviour {
static public string version = "";
public int objectType = 0;
public bool displayRoad = true;
public float roadWidth = 5.0f;
public float indent = 3.0f;
public float surrounding = 5.0f;
public float raise = 1.0f;
public float raiseMarkers = 0.5f;
public bool OOQDOOQQ = false;
public bool renderRoad = true;
public bool beveledRoad = false;
public bool applySplatmap = false;
public int splatmapLayer = 4;
public bool autoUpdate = true;
public float geoResolution = 5.0f;
public int roadResolution = 1;
public float tuw =  15.0f;
public int splatmapSmoothLevel;
public float opacity = 1.0f;
public int expand = 0;
public int offsetX = 0;
public int offsetY = 0;
private Material surfaceMaterial;
public float surfaceOpacity = 1.0f;
public float smoothDistance = 1.0f;
public float smoothSurDistance = 3.0f;
private bool handleInsertFlag;
public bool handleVegetation = true;
public float ODCQCQQQCO = 2.0f;
public float ODCCQCDCDQ = 1f;
public int materialType = 0;
String[] materialStrings;
public string uname;
public string email;
private MarkerScript[] mSc;

private bool ODQDOQCDQC;
private bool[] OCCDQODQCD = null;
private bool[] OQQCQQDOCQ = null;
public string[] OQDCCDQDOD;
public string[] ODODQOQO;
public int[] ODODQOQOInt;
public int ODCDCCOODQ = -1;
public int OCQDCCQCOD = -1;
static public GUISkin ODCOOCDQQC;
static public GUISkin OCOCCCDQCO;
public bool OODODOCCCC = false;
private Vector3 cPos;
private Vector3 ePos;
public bool ODDCQOCODC;
static public Texture2D ODCCDDCCDO;
public int markers = 1;
public OOCOOCQQDQ OQQCDCOCQO;
private GameObject ODOQDQOO;
public bool OCDCCDOOOD;
public bool doTerrain;
private Transform ODQDOQCCCO = null;
public GameObject[] ODQDOQCCCOs;
private static string ODOCCCQQDD = null;
public Transform obj;
private string ODDODDOQDO;
public static string erInit = "";
static public Transform OQQDCQCDCQ;
private RoadObjectScript OOOOOCQOCO;
public bool flyby;


private Vector3 pos;
private float fl;
private float oldfl;
private bool OQDOOQCOCO;
private bool ODCCOOCOQD;
private bool OCCQDDOQDQ;
public Transform ODOQCQDDCQ;
public int OdQODQOD = 1;
public float OOQQQDOD = 0f;
public float OOQQQDODOffset = 0f;
public float OOQQQDODLength = 0f;
public bool ODODDDOO = false;
static public string[] ODOQDOQO;
static public string[] ODODOQQO; 
static public string[] ODODQOOQ;
public int ODQDOOQO = 0;
public string[] ODQQQQQO;  
public string[] ODODDQOO; 
public bool[] ODODQQOD; 
public int[] OOQQQOQO; 
public int ODOQOOQO = 0; 

public bool forceY = false;
public float yChange = 0f;
public float floorDepth = 2f;
public float waterLevel = 1.5f; 
public bool lockWaterLevel = true;
public float lastY = 0f;
public string distance = "0";
public string markerDisplayStr = "Hide Markers";
static public string[] objectStrings;
public string objectText = "Road";
public bool applyAnimation = false;
public float waveSize = 1.5f;
public float waveHeight = 0.15f;
public bool snapY = true;

private TextAnchor origAnchor;
public bool autoODODDQQO;
public Texture2D roadTexture;
public Texture2D roadMaterial;
public string[] ODCQOQQDCQ;
public string[] ODCDODQODC;
public int selectedWaterMaterial;
public int selectedWaterScript;
private bool doRestore = false;
public bool doFlyOver;
public static GameObject tracer;
public Camera goCam;
public float speed = 1f;
public float offset = 0f;
public bool camInit;
public GameObject customMesh = null;
static public bool disableFreeAlerts = true;
public bool multipleTerrains;
public bool editRestore = true;
public Material roadMaterialEdit;
static public int backupLocation = 0;
public string[] backupStrings = new string[2]{"Outside Assets folder path","Inside Assets folder path"};
public Vector3[] leftVecs = new Vector3[0];
public Vector3[] rightVecs = new Vector3[0];
public bool applyTangents = false;
public bool sosBuild = false;
public float splinePos = 0;
public float camHeight = 3;
public Vector3 splinePosV3 = Vector3.zero;
public bool blendFlag; 
public float startBlendDistance = 5;
public float endBlendDistance = 5;
public bool iOS = false;
static public string extensionPath = "";
public void OQDCDCOODC(List<ODODDQQO> arr, String[] DOODQOQO, String[] OODDQOQO){

OCODQDOCOC(transform, arr, DOODQOQO, OODDQOQO);
}
public void OCOODDOOQQ(MarkerScript markerScript){

ODQDOQCCCO = markerScript.transform;



List<GameObject> tmp = new List<GameObject>();
for(int i=0;i<ODQDOQCCCOs.Length;i++){
if(ODQDOQCCCOs[i] != markerScript.gameObject)tmp.Add(ODQDOQCCCOs[i]);
}




tmp.Add(markerScript.gameObject);
ODQDOQCCCOs = tmp.ToArray();
ODQDOQCCCO = markerScript.transform;

OQQCDCOCQO.ODQCDOOQQQ(ODQDOQCCCO, ODQDOQCCCOs, markerScript.OQOQDOCQOC, markerScript.OQCCQDCDOQ, ODOQCQDDCQ, out markerScript.ODQDOQCCCOs, out markerScript.trperc, ODQDOQCCCOs);

OCQDCCQCOD = -1;
}
public void OCOQCOQQDO(MarkerScript markerScript){
if(markerScript.OQCCQDCDOQ != markerScript.ODOOQQOO || markerScript.OQCCQDCDOQ != markerScript.ODOOQQOO){
OQQCDCOCQO.ODQCDOOQQQ(ODQDOQCCCO, ODQDOQCCCOs, markerScript.OQOQDOCQOC, markerScript.OQCCQDCDOQ, ODOQCQDDCQ, out markerScript.ODQDOQCCCOs, out markerScript.trperc, ODQDOQCCCOs);
markerScript.ODQDOQOO = markerScript.OQOQDOCQOC;
markerScript.ODOOQQOO = markerScript.OQCCQDCDOQ;
}
if(OOOOOCQOCO.autoUpdate) ODCQOCDDDC(OOOOOCQOCO.geoResolution, false, false);
}
public void ResetMaterials(MarkerScript markerScript){
if(OQQCDCOCQO != null)OQQCDCOCQO.ODQCDOOQQQ(ODQDOQCCCO, ODQDOQCCCOs, markerScript.OQOQDOCQOC, markerScript.OQCCQDCDOQ, ODOQCQDDCQ, out markerScript.ODQDOQCCCOs, out markerScript.trperc, ODQDOQCCCOs);
}
public void OQCQDQCDDQ(MarkerScript markerScript){
if(markerScript.OQCCQDCDOQ != markerScript.ODOOQQOO){
OQQCDCOCQO.ODQCDOOQQQ(ODQDOQCCCO, ODQDOQCCCOs, markerScript.OQOQDOCQOC, markerScript.OQCCQDCDOQ, ODOQCQDDCQ, out markerScript.ODQDOQCCCOs, out markerScript.trperc, ODQDOQCCCOs);
markerScript.ODOOQQOO = markerScript.OQCCQDCDOQ;
}
ODCQOCDDDC(OOOOOCQOCO.geoResolution, false, false);
}
private void OOOCDDDQQO(string ctrl, MarkerScript markerScript){
int i = 0;
foreach(Transform tr in markerScript.ODQDOQCCCOs){
MarkerScript wsScript = (MarkerScript) tr.GetComponent<MarkerScript>();
if(ctrl == "rs") wsScript.LeftSurrounding(markerScript.rs - markerScript.ODOQQOOO, markerScript.trperc[i]);
else if(ctrl == "ls") wsScript.RightSurrounding(markerScript.ls - markerScript.DODOQQOO, markerScript.trperc[i]);
else if(ctrl == "ri") wsScript.LeftIndent(markerScript.ri - markerScript.OOQOQQOO, markerScript.trperc[i]);
else if(ctrl == "li") wsScript.RightIndent(markerScript.li - markerScript.ODODQQOO, markerScript.trperc[i]);
else if(ctrl == "rt") wsScript.LeftTilting(markerScript.rt - markerScript.ODDQODOO, markerScript.trperc[i]);
else if(ctrl == "lt") wsScript.RightTilting(markerScript.lt - markerScript.ODDOQOQQ, markerScript.trperc[i]);
else if(ctrl == "floorDepth") wsScript.FloorDepth(markerScript.floorDepth - markerScript.oldFloorDepth, markerScript.trperc[i]);
i++;
}
}
public void OQCCDQDCDQ(){
if(markers > 1) ODCQOCDDDC(OOOOOCQOCO.geoResolution, false, false);
}
public void OCODQDOCOC(Transform tr, List<ODODDQQO> arr, String[] DOODQOQO, String[] OODDQOQO){
version = "2.5.7";
ODCOOCDQQC = (GUISkin)Resources.Load("ER3DSkin", typeof(GUISkin));


ODCCDDCCDO = (Texture2D)Resources.Load("ER3DLogo", typeof(Texture2D));
if(RoadObjectScript.objectStrings == null){
RoadObjectScript.objectStrings = new string[3];
RoadObjectScript.objectStrings[0] = "Road Object"; RoadObjectScript.objectStrings[1]="River Object";RoadObjectScript.objectStrings[2]="Procedural Mesh Object";
}
obj = tr;
OQQCDCOCQO = new OOCOOCQQDQ();
OOOOOCQOCO = obj.GetComponent<RoadObjectScript>();
foreach(Transform child in obj){
if(child.name == "Markers") ODOQCQDDCQ = child;
}
RoadObjectScript[] rscrpts = (RoadObjectScript[])FindObjectsOfType(typeof(RoadObjectScript));
OOCOOCQQDQ.terrainList.Clear();
Terrain[] terrains = (Terrain[])FindObjectsOfType(typeof(Terrain));
foreach(Terrain terrain in terrains) {
Terrains t = new Terrains();
t.terrain = terrain;
if(!terrain.gameObject.GetComponent<EasyRoads3DTerrainID>()){
EasyRoads3DTerrainID terrainscript = (EasyRoads3DTerrainID)terrain.gameObject.AddComponent<EasyRoads3DTerrainID>();
string id = UnityEngine.Random.Range(100000000,999999999).ToString();
terrainscript.terrainid = id;
t.id = id;
}else{
t.id = terrain.gameObject.GetComponent<EasyRoads3DTerrainID>().terrainid;
}
OOCOOCQQDQ.OODOQDQODQ(t);
}
ODCCQOCQOD.OODOQDQODQ();
if(roadMaterialEdit == null){
roadMaterialEdit = (Material)Resources.Load("materials/roadMaterialEdit", typeof(Material));
}
if(objectType == 0 && GameObject.Find(gameObject.name + "/road") == null){
GameObject road = new GameObject("road");
road.transform.parent = transform;
}

OQQCDCOCQO.OOCOCQOOQC(obj, ODOCCCQQDD, OOOOOCQOCO.roadWidth, surfaceOpacity, out ODDCQOCODC, out indent, applyAnimation, waveSize, waveHeight);
OQQCDCOCQO.ODCCQCDCDQ = ODCCQCDCDQ;
OQQCDCOCQO.ODCQCQQQCO = ODCQCQQQCO;
OQQCDCOCQO.OdQODQOD = OdQODQOD + 1;
OQQCDCOCQO.OOQQQDOD = OOQQQDOD;
OQQCDCOCQO.OOQQQDODOffset = OOQQQDODOffset;
OQQCDCOCQO.OOQQQDODLength = OOQQQDODLength;
OQQCDCOCQO.objectType = objectType;
OQQCDCOCQO.snapY = snapY;
OQQCDCOCQO.terrainRendered = OCDCCDOOOD;
OQQCDCOCQO.handleVegetation = handleVegetation;
OQQCDCOCQO.raise = raise;
OQQCDCOCQO.roadResolution = roadResolution;
OQQCDCOCQO.multipleTerrains = multipleTerrains;
OQQCDCOCQO.editRestore = editRestore;
OQQCDCOCQO.roadMaterialEdit = roadMaterialEdit;
OQQCDCOCQO.renderRoad = renderRoad;
OQQCDCOCQO.rscrpts = rscrpts.Length;
OQQCDCOCQO.blendFlag = blendFlag; 
OQQCDCOCQO.startBlendDistance = startBlendDistance;
OQQCDCOCQO.endBlendDistance = endBlendDistance;

OQQCDCOCQO.iOS = iOS;

if(backupLocation == 0)OCQQOCDCCD.backupFolder = "/EasyRoads3D";
else OCQQOCDCCD.backupFolder =  OCQQOCDCCD.extensionPath + "/Backups";

ODODQOQO = OQQCDCOCQO.OOOCCQCQOO();
ODODQOQOInt = OQQCDCOCQO.OOOODCDDOQ();


if(OCDCCDOOOD){




doRestore = true;
}


OOCOOQCQQD();

if(arr != null || ODODQOOQ == null) OQQODDQCQD(arr, DOODQOQO, OODDQOQO);


if(doRestore) return;
}
public void UpdateBackupFolder(){
}
public void ODCCDOOOQO(){
if(!ODODDDOO || objectType == 2){
if(OCCDQODQCD != null){
for(int i = 0; i < OCCDQODQCD.Length; i++){
OCCDQODQCD[i] = false;
OQQCQQDOCQ[i] = false;
}
}
}
}

public void OCOCDDCDDO(Vector3 pos){


if(!displayRoad){
displayRoad = true;
OQQCDCOCQO.OQOOCOOCQC(displayRoad, ODOQCQDDCQ);
}
pos.y += OOOOOCQOCO.raiseMarkers;
if(forceY && ODOQDQOO != null){
float dist = Vector3.Distance(pos, ODOQDQOO.transform.position);
pos.y = ODOQDQOO.transform.position.y + (yChange * (dist / 100f));
}else if(forceY && markers == 0) lastY = pos.y;
GameObject go = null;
if(ODOQDQOO != null) go = (GameObject)Instantiate(ODOQDQOO);
else go = (GameObject)Instantiate(Resources.Load("marker", typeof(GameObject)));
Transform newnode = go.transform;
newnode.position = pos;
newnode.parent = ODOQCQDDCQ;
markers++;
string n;
if(markers < 10) n = "Marker000" + markers.ToString();
else if (markers < 100) n = "Marker00" + markers.ToString();
else n = "Marker0" + markers.ToString();
newnode.gameObject.name = n;
MarkerScript scr = newnode.GetComponent<MarkerScript>();
scr.ODDCQOCODC = false;
scr.objectScript = obj.GetComponent<RoadObjectScript>();
if(ODOQDQOO == null){
scr.waterLevel = OOOOOCQOCO.waterLevel;
scr.floorDepth = OOOOOCQOCO.floorDepth;
scr.ri = OOOOOCQOCO.indent;
scr.li = OOOOOCQOCO.indent;
scr.rs = OOOOOCQOCO.surrounding;
scr.ls = OOOOOCQOCO.surrounding;
scr.tension = 0.5f;
if(objectType == 1){

pos.y -= waterLevel;
newnode.position = pos;
}
}
if(objectType == 2){
#if UNITY_3_5
if(scr.surface != null)scr.surface.gameObject.active = false;
#else
if(scr.surface != null)scr.surface.gameObject.SetActive(false);
#endif
}
ODOQDQOO = newnode.gameObject;
if(markers > 1){
ODCQOCDDDC(OOOOOCQOCO.geoResolution, false, false);
if(materialType == 0){

OQQCDCOCQO.OCDDQQCCCO(materialType);

}
}
}
public void ODCQOCDDDC(float geo, bool renderMode, bool camMode){
OQQCDCOCQO.ODDODQOCQO.Clear();
int ii = 0;
OCQODDOCQD k;
foreach(Transform child  in obj)
{
if(child.name == "Markers"){
foreach(Transform marker   in child) {
MarkerScript markerScript = marker.GetComponent<MarkerScript>();
markerScript.objectScript = obj.GetComponent<RoadObjectScript>();
if(!markerScript.ODDCQOCODC) markerScript.ODDCQOCODC = OQQCDCOCQO.OOCDQOCOQQ(marker);
k  = new OCQODDOCQD();
k.position = marker.position;
k.num = OQQCDCOCQO.ODDODQOCQO.Count;
k.object1 = marker;
k.object2 = markerScript.surface;
k.tension = markerScript.tension;
k.ri = markerScript.ri;
if(k.ri < 1)k.ri = 1f;
k.li =markerScript.li;
if(k.li < 1)k.li = 1f;
k.rt = markerScript.rt;
k.lt = markerScript.lt;
k.rs = markerScript.rs;
if(k.rs < 1)k.rs = 1f;
k.ODQQQQQOQC = markerScript.rs;
k.ls = markerScript.ls;
if(k.ls < 1)k.ls = 1f;
k.OOQDCCOOOO = markerScript.ls;
k.renderFlag = markerScript.bridgeObject;
k.OOCOODCCQC = markerScript.distHeights;
k.newSegment = markerScript.newSegment;
k.tunnelFlag = markerScript.tunnelFlag;
k.floorDepth = markerScript.floorDepth;
k.waterLevel = waterLevel;
k.lockWaterLevel = markerScript.lockWaterLevel;
k.sharpCorner = markerScript.sharpCorner;
k.OCDOCOQOCD = OQQCDCOCQO;
markerScript.markerNum = ii;
markerScript.distance = "-1";
markerScript.OQCCOCCDOD = "-1";
OQQCDCOCQO.ODDODQOCQO.Add(k);
ii++;
}
}
}
distance = "-1";

OQQCDCOCQO.ODDQDCOCQC = OOOOOCQOCO.roadWidth;

OQQCDCOCQO.OCOOQCCQCQ(geo, obj, OOOOOCQOCO.OOQDOOQQ, renderMode, camMode, objectType);
if(OQQCDCOCQO.leftVecs.Count > 0){
leftVecs = OQQCDCOCQO.leftVecs.ToArray();
rightVecs = OQQCDCOCQO.rightVecs.ToArray();
}
}
public void StartCam(){

ODCQOCDDDC(0.5f, false, true);

}
public void OOCOOQCQQD(){
int i = 0;
foreach(Transform child  in obj)
{
if(child.name == "Markers"){
i = 1;
string n;
foreach(Transform marker in child) {
if(i < 10) n = "Marker000" + i.ToString();
else if (i < 100) n = "Marker00" + i.ToString();
else n = "Marker0" + i.ToString();
marker.name = n;
ODOQDQOO = marker.gameObject;
i++;
}
}
}
markers = i - 1;

ODCQOCDDDC(OOOOOCQOCO.geoResolution, false, false);
}
public List<Transform> RebuildObjs(){
RoadObjectScript[] scripts = (RoadObjectScript[])FindObjectsOfType(typeof(RoadObjectScript));
List<Transform> rObj = new List<Transform>();
foreach (RoadObjectScript script in scripts) {
if(script.transform != transform) rObj.Add(script.transform);
}
return rObj;
}
public void RestoreTerrain1(){

ODCQOCDDDC(OOOOOCQOCO.geoResolution, false, false);
if(OQQCDCOCQO != null) OQQCDCOCQO.OCODCCCOCD();
ODODDDOO = false;
}
public void ODCOQQDDDQ(){
OQQCDCOCQO.ODCOQQDDDQ(OOOOOCQOCO.applySplatmap, OOOOOCQOCO.splatmapSmoothLevel, OOOOOCQOCO.renderRoad, OOOOOCQOCO.tuw, OOOOOCQOCO.roadResolution, OOOOOCQOCO.raise, OOOOOCQOCO.opacity, OOOOOCQOCO.expand, OOOOOCQOCO.offsetX, OOOOOCQOCO.offsetY, OOOOOCQOCO.beveledRoad, OOOOOCQOCO.splatmapLayer, OOOOOCQOCO.OdQODQOD, OOQQQDOD, OOQQQDODOffset, OOQQQDODLength);
}
public void OQDDODOCDO(){
OQQCDCOCQO.OQDDODOCDO(OOOOOCQOCO.renderRoad, OOOOOCQOCO.tuw, OOOOOCQOCO.roadResolution, OOOOOCQOCO.raise, OOOOOCQOCO.beveledRoad, OOOOOCQOCO.OdQODQOD, OOQQQDOD, OOQQQDODOffset, OOQQQDODLength);
}
public void OCQQDCOCCQ(Vector3 pos, bool doInsert){


if(!displayRoad){
displayRoad = true;
OQQCDCOCQO.OQOOCOOCQC(displayRoad, ODOQCQDDCQ);
}

int first = -1;
int second = -1;
float dist1 = 10000;
float dist2 = 10000;
Vector3 newpos = pos;
OCQODDOCQD k;
OCQODDOCQD k1 = (OCQODDOCQD)OQQCDCOCQO.ODDODQOCQO[0];
OCQODDOCQD k2 = (OCQODDOCQD)OQQCDCOCQO.ODDODQOCQO[1];

if(doInsert){
Debug.Log("Start Insert" + doInsert);
}
OQQCDCOCQO.ODOOQDCDQQ(pos, out first, out second, out dist1, out dist2, out k1, out k2, out newpos, doInsert);
if(doInsert){
Debug.Log("marker 1: " + first);
Debug.Log("marker 2: " + second);
}
pos = newpos;
if(doInsert && first >= 0 && second >= 0){
if(OOOOOCQOCO.OOQDOOQQ && second == OQQCDCOCQO.ODDODQOCQO.Count - 1){
OCOCDDCDDO(pos);
}else{
k = (OCQODDOCQD)OQQCDCOCQO.ODDODQOCQO[second];
string name = k.object1.name;
string n;
int j = second + 2;
for(int i = second; i < OQQCDCOCQO.ODDODQOCQO.Count - 1; i++){
k = (OCQODDOCQD)OQQCDCOCQO.ODDODQOCQO[i];
if(j < 10) n = "Marker000" + j.ToString();
else if (j < 100) n = "Marker00" + j.ToString();
else n = "Marker0" + j.ToString();
k.object1.name = n;
j++;
}
k = (OCQODDOCQD)OQQCDCOCQO.ODDODQOCQO[first];
Transform newnode = (Transform)Instantiate(k.object1.transform, pos, k.object1.rotation);
newnode.gameObject.name = name;
newnode.parent = ODOQCQDDCQ;
#if UNITY_4_5
newnode.SetSiblingIndex(second);
#elif UNITY_4_6
newnode.SetSiblingIndex(second);
#elif UNITY_5_0
newnode.SetSiblingIndex(second);
#endif
MarkerScript scr = newnode.GetComponent<MarkerScript>();
scr.ODDCQOCODC = false;
float	totalDist = dist1 + dist2;
float perc1 = dist1 / totalDist;
float paramDif = k1.ri - k2.ri;
scr.ri = k1.ri - (paramDif * perc1);
paramDif = k1.li - k2.li;
scr.li = k1.li - (paramDif * perc1);
paramDif = k1.rt - k2.rt;
scr.rt = k1.rt - (paramDif * perc1);
paramDif = k1.lt - k2.lt;
scr.lt = k1.lt - (paramDif * perc1);
paramDif = k1.rs - k2.rs;
scr.rs = k1.rs - (paramDif * perc1);
paramDif = k1.ls - k2.ls;
scr.ls = k1.ls - (paramDif * perc1);
ODCQOCDDDC(OOOOOCQOCO.geoResolution, false, false);
if(materialType == 0)OQQCDCOCQO.OCDDQQCCCO(materialType);
#if UNITY_3_5
if(objectType == 2) scr.surface.gameObject.active = false;
#else
if(objectType == 2) scr.surface.gameObject.SetActive(false);
#endif
}
}
OOCOOQCQQD();
}
public void OCQQCODCCC(){

DestroyImmediate(OOOOOCQOCO.ODQDOQCCCO.gameObject);
ODQDOQCCCO = null;
OOCOOQCQQD();
}
public void OQOQCQODQQ(){

OQQCDCOCQO.OCCDCODDCC(12);

}

public List<SideObjectParams> OQOOQQDCQC(){

List<SideObjectParams> param = new List<SideObjectParams>();
SideObjectParams sop;
foreach(Transform child in obj){
if(child.name == "Markers"){
foreach(Transform marker in child){
MarkerScript markerScript = marker.GetComponent<MarkerScript>();
sop  = new SideObjectParams();
sop.ODDGDOOO = markerScript.ODDGDOOO;
sop.ODDQOODO = markerScript.ODDQOODO;
sop.ODDQOOO = markerScript.ODDQOOO;
param.Add(sop);
}
}
}
return param;

}
public void OOQQCOCCCQ(){

List<string> arrNames = new List<string>();
List<int> arrInts = new List<int>();
List<string> arrIDs = new List<string>();

for(int i=0;i<ODODOQQO.Length;i++){
if(ODODQQOD[i] == true){
arrNames.Add(ODODQOOQ[i]);
arrIDs.Add(ODODOQQO[i]);
arrInts.Add(i);
}
}
ODODDQOO = arrNames.ToArray();
OOQQQOQO = arrInts.ToArray();

}
public void OQQODDQCQD(List<ODODDQQO> arr, String[] DOODQOQO, String[] OODDQOQO){




bool saveSOs = false;
ODODOQQO = DOODQOQO;
ODODQOOQ = OODDQOQO;






List<MarkerScript> markerArray = new List<MarkerScript>();
if(obj == null)OCODQDOCOC(transform, null, null, null);
foreach(Transform child  in obj) {
if(child.name == "Markers"){
foreach(Transform marker  in child) {
MarkerScript markerScript = marker.GetComponent<MarkerScript>();
markerScript.OQODQQDO.Clear();
markerScript.ODOQQQDO.Clear();
markerScript.OQQODQQOO.Clear();
markerScript.ODDOQQOO.Clear();
markerArray.Add(markerScript);
}
}
}
mSc = markerArray.ToArray();





List<bool> arBools = new List<bool>();



int counter1 = 0;
int counter2 = 0;

if(ODQQQQQO != null){

if(arr.Count == 0) return;



for(int i = 0; i < ODODOQQO.Length; i++){
ODODDQQO so = (ODODDQQO)arr[i];

for(int j = 0; j < ODQQQQQO.Length; j++){
if(ODODOQQO[i] == ODQQQQQO[j]){
counter1++;


if(ODODQQOD.Length > j ) arBools.Add(ODODQQOD[j]);
else arBools.Add(false);

foreach(MarkerScript scr  in mSc) {


int l = -1;
for(int k = 0; k < scr.ODDOOQDO.Length; k++){
if(so.id == scr.ODDOOQDO[k]){
l = k;
break;
}
}
if(l >= 0){
scr.OQODQQDO.Add(scr.ODDOOQDO[l]);
scr.ODOQQQDO.Add(scr.ODDGDOOO[l]);
scr.OQQODQQOO.Add(scr.ODDQOOO[l]);

if(so.sidewaysDistanceUpdate == 0 || (so.sidewaysDistanceUpdate == 2 && (float)scr.ODDQOODO[l] != so.oldSidwaysDistance)){
scr.ODDOQQOO.Add(scr.ODDQOODO[l]);

}else{
scr.ODDOQQOO.Add(so.splinePosition);

}




}else{
scr.OQODQQDO.Add(so.id);
scr.ODOQQQDO.Add(so.markerActive);
scr.OQQODQQOO.Add(true);
scr.ODDOQQOO.Add(so.splinePosition);
}

}
}
}
if(so.sidewaysDistanceUpdate != 0){



}
saveSOs = false;
}
}


for(int i = 0; i < ODODOQQO.Length; i++){
ODODDQQO so = (ODODDQQO)arr[i];
bool flag = false;
for(int j = 0; j < ODQQQQQO.Length; j++){

if(ODODOQQO[i] == ODQQQQQO[j])flag = true;
}
if(!flag){
counter2++;

arBools.Add(false);

foreach(MarkerScript scr  in mSc) {
scr.OQODQQDO.Add(so.id);
scr.ODOQQQDO.Add(so.markerActive);
scr.OQQODQQOO.Add(true);
scr.ODDOQQOO.Add(so.splinePosition);
}

}
}

ODODQQOD = arBools.ToArray();


ODQQQQQO = new String[ODODOQQO.Length];
ODODOQQO.CopyTo(ODQQQQQO,0);





List<int> arInt= new List<int>();
for(int i = 0; i < ODODQQOD.Length; i++){
if(ODODQQOD[i]) arInt.Add(i);
}
OOQQQOQO  = arInt.ToArray();


foreach(MarkerScript scr  in mSc) {
scr.ODDOOQDO = scr.OQODQQDO.ToArray();
scr.ODDGDOOO = scr.ODOQQQDO.ToArray();
scr.ODDQOOO = scr.OQQODQQOO.ToArray();
scr.ODDQOODO = scr.ODDOQQOO.ToArray();

}
if(saveSOs){

}




}
public void SetMultipleTerrains(bool flag){
RoadObjectScript[] scrpts = (RoadObjectScript[])FindObjectsOfType(typeof(RoadObjectScript));
foreach(RoadObjectScript scr in scrpts){
scr.multipleTerrains = flag;
if(scr.OQQCDCOCQO != null)scr.OQQCDCOCQO.multipleTerrains = flag;
}
}
public bool CheckWaterHeights(){
if(ODCCQOCQOD.terrain == null) return false;
bool flag = true;

float y = ODCCQOCQOD.terrain.transform.position.y;
foreach(Transform child  in obj) {
if(child.name == "Markers"){
foreach(Transform marker  in child) {

if(marker.position.y - y <= 0.1f) flag = false;
}
}
}
return flag;
}
}

using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using EasyRoads3D;
public class OCCQCCODDD{

static public void ODCOCCQCCC(RoadObjectScript target){


OCOQDQCQDO.OOOOOOOCQO(target.transform);

List<ODODDQQO> arr = OCOQDQCQDO.OOOCODQOOQ(false);
target.OQQODDQCQD(arr, OCOQDQCQDO.ODOCQDDCCD(arr), OCOQDQCQDO.ODCOCCOQCQ(arr));
Transform mySideObject = ODDQDODCCQ(target);
OQODOCQQCO(target.OQQCDCOCQO, target.transform, target.OQOOQQDCQC(), target.OOQDOOQQ, target.OOQQQOQO, target.raise, target, mySideObject);



target.ODODDDOO = true;

}
static public void OQODOCQQCO(OOCOOCQQDQ OQQCDCOCQO, Transform obj , List<SideObjectParams> param , bool OOQDOOQQ ,  int[] activeODODDQQO , float raise, RoadObjectScript target , Transform mySideObject){
List<OCQODDOCQD> pnts  = target.OQQCDCOCQO.ODDODQOCQO;
List<ODODDQQO> arr  = OCOQDQCQDO.OOOCODQOOQ(false);
for(int i = 0; i < activeODODDQQO.Length; i++){  
ODODDQQO so = (ODODDQQO)arr[activeODODDQQO[i]];

GameObject goi  = null;
if(so.OCDDCOQDOD != "") goi =  (GameObject)AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(so.OCDDCOQDOD), typeof(GameObject));
GameObject ODQDDDDCQD = null;
if(so.OQCCDQOCQQ != "") ODQDDDDCQD = (GameObject)AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(so.OQCCDQOCQQ), typeof(GameObject));
GameObject OQQDQOOCQO = null;
if(so.OOQODOQQDC != "") OQQDQOOCQO =  (GameObject)AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(so.OOQODOQQDC), typeof(GameObject));
OCOQDQCQDO.OOCDCQCCCO(so, pnts, obj, OQQCDCOCQO, param, OOQDOOQQ, activeODODDQQO[i], raise, goi, ODQDDDDCQD, OQQDQOOCQO);
if(so.terrainTree > 0){

if(EditorUtility.DisplayDialog("Side Objects", "Side Object " + so.name + " in " + target.gameObject.name + " includes an asset part of the terrain vegetation data.\n\nWould you like to add this side object to the terrain vegetation data?", "yes","no")){
foreach(Transform child in mySideObject){
if(child.gameObject.name == so.name){
OCOQDQCQDO.OOQQCDCODQ(activeODODDQQO[i], child);
MonoBehaviour.DestroyImmediate(child.gameObject);
break;
}
}
}
}
foreach(Transform child in mySideObject)if(child.gameObject.GetComponent(typeof(sideObjectScript)) != null) MonoBehaviour.DestroyImmediate(child.gameObject.GetComponent(typeof(sideObjectScript)));
}
}

static public void OOOQDQCCDQ(sideObjectScript scr, int index, RoadObjectScript target, Transform go){
string n = go.gameObject.name;
Transform p = go.parent;

if(go != null){
MonoBehaviour.DestroyImmediate(go.gameObject);
}
List<ODODDQQO> arr = OCOQDQCQDO.OOOCODQOOQ(false);
ODODDQQO so = (ODODDQQO)arr[index];

OQDQQDODCD(n, p, so, index, target);

GameObject goi  = null;
if(so.OCDDCOQDOD != "") goi =  (GameObject)AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(so.OCDDCOQDOD), typeof(GameObject));
GameObject ODQDDDDCQD = null;
if(so.OQCCDQOCQQ != "") ODQDDDDCQD = (GameObject)AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(so.OQCCDQOCQQ), typeof(GameObject));
GameObject OQQDQOOCQO = null;
if(so.OOQODOQQDC != "") OQQDQOOCQO =  (GameObject)AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(so.OOQODOQQDC), typeof(GameObject));

OCOQDQCQDO.OOODCQDOQO(target.OQQCDCOCQO, target.transform, target.OQOOQQDCQC(), target.OOQDOOQQ, index, target.raise, goi, ODQDDDDCQD, OQQDQOOCQO);
arr = null;
}

static public Transform ODDQDODCCQ(RoadObjectScript target){

GameObject go  =  new GameObject("Side Objects");

go.transform.parent = target.transform;
List<ODODDQQO> arr = OCOQDQCQDO.OOOCODQOOQ(false);
for(int i = 0; i < target.OOQQQOQO.Length; i++){  
ODODDQQO so = (ODODDQQO)arr[target.OOQQQOQO[i]];
OQDQQDODCD(so.name, go.transform, so, target.OOQQQOQO[i], target);
}
return go.transform;
}
static public void OQDQQDODCD(string objectname, Transform obj, ODODDQQO so, int index, RoadObjectScript target){



Transform rootObject = null;

foreach(Transform child1 in obj)
{
if(child1.name == objectname){
rootObject = child1;

if(so.textureGUID !=""){
MeshRenderer mr  = (MeshRenderer)rootObject.transform.GetComponent(typeof(MeshRenderer));
Material mat =  (Material)AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(so.textureGUID), typeof(Material));
mr.material = mat;

}
}
}
if(rootObject == null){
GameObject go  =  new GameObject(objectname);
go.name = objectname;
go.transform.parent = obj;
rootObject = go.transform;

go.AddComponent(typeof(MeshFilter));
go.AddComponent(typeof(MeshRenderer));
go.AddComponent(typeof(MeshCollider));
go.AddComponent(typeof(sideObjectScript));
sideObjectScript scr = (sideObjectScript)go.GetComponent(typeof(sideObjectScript));
if(so.textureGUID !=""){
MeshRenderer mr = (MeshRenderer)go.GetComponent(typeof(MeshRenderer));
Material mat =  (Material)AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(so.textureGUID), typeof(Material));
mr.material = mat;
scr.mat = mat;
}
scr.soIndex = index;
scr.soName = so.name;

scr.soAlign = int.Parse(so.align);
scr.soUVx = so.uvx;
scr.soUVy = so.uvy;
scr.m_distance = so.m_distance;
scr.objectType = so.objectType;
scr.weld = so.weld;
scr.combine = so.combine;
scr.OODCQOQDDC = so.OODCQOQDDC;
scr.m_go = so.OCDDCOQDOD;
if(so.OQCCDQOCQQ != ""){
scr.OQCCDQOCQQ = so.OQCCDQOCQQ;

}
if(so.OQCCDQOCQQ != ""){
scr.OOQODOQQDC = so.OOQODOQQDC;

}
scr.selectedRotation = so.selectedRotation;
scr.position = so.position;
scr.uvInt = so.uvType;
scr.randomObjects = so.randomObjects;
scr.childOrder = so.childOrder;
scr.sidewaysOffset = so.sidewaysOffset;
scr.density = so.density;
scr.OOOOOCQOCO = target;
scr.terrainTree = so.terrainTree;
scr.xPosition = so.xPosition;
scr.yPosition = so.yPosition;
scr.uvYRound = so.uvYRound;
scr.m_collider = so.collider;
scr.m_tangents = so.tangents;

}
}

}

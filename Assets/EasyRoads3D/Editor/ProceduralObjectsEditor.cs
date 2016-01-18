using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using EasyRoads3D;
using EasyRoads3DEditor;
public class ProceduralObjectsEditor : EditorWindow
{

public static ProceduralObjectsEditor instance;
public ODQQQCQQOD so_editor;
public int sideObject;
private ODODDQQO so;

private GameObject so_go;

string[] traceStrings;

public ProceduralObjectsEditor() {
instance = this;
}
void OnDestroy(){
OODCCQQQCC.OnDestroy1();
instance = null;
}
public void DisplayNodes (int index, ODODDQQO soi, GameObject sso_go)

{
so_go = sso_go;
List<Vector2> tmpNodes = new List<Vector2>();
if(soi != null) tmpNodes.AddRange(soi.nodeList);

if(so_go != null && tmpNodes.Count == 0){

List<Vector2> arr = ODQQQCQQOD.OCCOCQCDDD(2, so_go, OODCCQQQCC.traceOffset);
if(arr != null){
if(arr.Count > 1){
tmpNodes = arr;
}
}
}
bool clamped = false;
so = soi;
sideObject = index;
if (so_editor == null){
try{
so_editor = new ODQQQCQQOD(position, tmpNodes, clamped);
}catch{
}
}



if(so_editor.ODQCCCQDDQ.Count > 0){
if((Vector2)so_editor.ODQCCCQDDQ[0] == (Vector2)so_editor.ODQCCCQDDQ[so_editor.ODQCCCQDDQ.Count - 1]){

so_editor.closed = true;
so_editor.ODQCCCQDDQ.RemoveAt(so_editor.ODQCCCQDDQ.Count - 1);
}
}
if(tmpNodes.Count != 0){
Rect rect = new Rect(stageSelectionGridWidth, 0, Screen.width - stageSelectionGridWidth, Screen.height);
so_editor.FrameSelected(rect);
}
OODCCQQQCC.OCOCOODCCQ(index, soi, sso_go, so_editor);
return;
}
void OnGUI ()
{
Rect rect = new Rect(stageSelectionGridWidth, 0, Screen.width - stageSelectionGridWidth, Screen.height);
EditorGUILayout.BeginHorizontal();
GUILayout.Space(210);
GUILayout.Label(new GUIContent("Hit [r] to center the editor, hit [z] to zoom in on the nodes, click drag to move the canvas, Scrollwheel (or [shift] click drag) zoom in / out", ""), GUILayout.Width(800) );
EditorGUILayout.EndHorizontal();
GUILayout.Space(-15);
OODCCQQQCC.OCCCCCQQQD(rect);
DoGUI ();
so_editor.OnGUI(rect);
}
float stageSelectionGridWidth = 200;
void DoGUI ()
{

EditorGUILayout.BeginHorizontal();
GUILayout.Space(60);
if(GUILayout.Button ("Apply", GUILayout.Width(65))){
OODCCQQQCC.OOODOOOOOC();
instance.Close();
}
if(GUILayout.Button ("Close", GUILayout.Width(65))){
instance.Close();
}
EditorGUILayout.EndHorizontal();
GUILayout.Space(5);
if(so_editor.isChanged == false) GUI.enabled = false;
EditorGUILayout.BeginHorizontal();
GUILayout.Space(60);
if(GUILayout.Button ("Update Scene", GUILayout.Width(135))){

so.nodeList.Clear();
if(so_editor.closed) so_editor.ODQCCCQDDQ.Add(so_editor.ODQCCCQDDQ[0]);
so.nodeList.AddRange(so_editor.ODQCCCQDDQ);
so_editor.isChanged = false;
ODOCDDOOCC.OOCOQQOQCD(ODOCDDOOCC.selectedObject);
ODOCDDOOCC.OOOODODOQQ();

List<ODODDQQO> arr = OCOQDQCQDO.OOOCODQOOQ(false);
RoadObjectScript.ODODOQQO = OCOQDQCQDO.ODOCQDDCCD(arr);
RoadObjectScript[] scripts = (RoadObjectScript[])FindObjectsOfType(typeof(RoadObjectScript));
foreach(RoadObjectScript scr in scripts){

if(scr.OQQCDCOCQO == null) {
List<ODODDQQO> arr1  = OCOQDQCQDO.OOOCODQOOQ(false);
scr.OQDCDCOODC(arr1, OCOQDQCQDO.ODOCQDDCCD(arr1), OCOQDQCQDO.ODCOCCOQCQ(arr1));
}
scr.OQQODDQCQD(arr, OCOQDQCQDO.ODOCQDDCCD(arr), OCOQDQCQDO.ODCOCCOQCQ(arr));
if(scr.OCDCCDOOOD == true || scr.objectType == 2){
GameObject go = GameObject.Find(scr.gameObject.name+"/Side Objects/"+so.name);


if(go != null){
OCCQCCODDD.OOOQDQCCDQ((sideObjectScript)go.GetComponent(typeof(sideObjectScript)), sideObject, scr, go.transform);
}
}
}
}
EditorGUILayout.EndHorizontal();
GUI.enabled = true;
if (GUI.changed)
{
so_editor.isChanged = true;

}
Handles.color = Color.black;
Handles.DrawLine(new Vector2 (stageSelectionGridWidth,0), new Vector2 (stageSelectionGridWidth,Screen.height));

Handles.DrawLine(new Vector2 (stageSelectionGridWidth - 1,0), new Vector2 (stageSelectionGridWidth - 1,Screen.height));

}

}

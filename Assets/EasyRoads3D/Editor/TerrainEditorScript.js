@CustomEditor(EasyRoads3DTerrainID)
class TerrainEditorScript extends Editor
{
function OnSceneGUI()
{
if(Event.current.shift && RoadObjectScript.OQQDCQCDCQ != null) Selection.activeGameObject = RoadObjectScript.OQQDCQCDCQ.gameObject;
else RoadObjectScript.OQQDCQCDCQ = null;
}
}

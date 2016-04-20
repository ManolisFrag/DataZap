#pragma strict

var pauseCanvas : Canvas;
function Start () {
    Screen.lockCursor = true;
    Cursor.visible = false;
}

function Update () 
{
    if (Input.GetKeyDown(KeyCode.Escape))
    {
        //(gameObject.Find("Third Person Controller").GetComponent("MouseLook") as MonoBehaviour).enabled = false;
        (gameObject.Find("Main Camera").GetComponent("MouseLook") as MonoBehaviour).enabled = false;
        pauseCanvas.enabled = true;
        Time.timeScale = 0;
        Screen.lockCursor = false;
        Cursor.visible = true;
    }


}

function ResumeGame () {

}
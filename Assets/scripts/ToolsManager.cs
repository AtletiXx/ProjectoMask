using UnityEngine;
using UnityEngine.InputSystem;

public class ToolsManager : MonoBehaviour
{
    public GameObject Manos;
    public GameObject Aguja;
    public GameObject Tijeras;

    private GameObject currentTool;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Manos.SetActive(false);
        Aguja.SetActive(false);
        Tijeras.SetActive(false);
        SelectTool(Aguja);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.digit1Key.wasPressedThisFrame)
            SelectTool(Manos);

        if (Keyboard.current.digit2Key.wasPressedThisFrame)
            SelectTool(Aguja);

        if (Keyboard.current.digit3Key.wasPressedThisFrame)
            SelectTool(Tijeras);
    }


    private void SelectTool(GameObject tool)
    {
        if (currentTool != null)
            currentTool.SetActive(false);
        
        currentTool = tool;
        currentTool.SetActive(true);
    }
}

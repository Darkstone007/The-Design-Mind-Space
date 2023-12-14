using TMPro; // Add this directive to use TextMeshPro components
using UnityEngine;
using UnityEngine.UI;

public class RoomCreator : MonoBehaviour
{
    public GameObject wallPrefab;
    public TMP_InputField LengthInput, WidthInput, HeightInput; // Change to TMP_InputField
    public Slider RedSlider, GreenSlider, BlueSlider;
    public Button CreateRoomButton; // Change to TMP_Button if you're using a TextMeshPro button
    public Canvas roomCreationUI; // Assign your UI Canvas here in the inspector

    void Start()
    {
        CreateRoomButton.onClick.AddListener(CreateRoom);
    }

    void CreateRoom()
    {
        float length = float.Parse(LengthInput.text);
        float width = float.Parse(WidthInput.text);
        float height = float.Parse(HeightInput.text);
        Color roomColor = new Color(RedSlider.value, GreenSlider.value, BlueSlider.value);

        // Create floor and ceiling
        CreatePanel(new Vector3(0, 0, 0), new Vector3(width, 1, length), roomColor); // Floor
        CreatePanel(new Vector3(0, height, 0), new Vector3(width, 1, length), roomColor); // Ceiling

        // Create walls
        CreatePanel(new Vector3(0, height / 2, length / 2), new Vector3(width, height, 1), roomColor); // Front
        CreatePanel(new Vector3(0, height / 2, -length / 2), new Vector3(width, height, 1), roomColor); // Back
        CreatePanel(new Vector3(width / 2, height / 2, 0), new Vector3(1, height, length), roomColor); // Right
        CreatePanel(new Vector3(-width / 2, height / 2, 0), new Vector3(1, height, length), roomColor); // Left

        // Calculate the center of the room
        Vector3 roomCenter = new Vector3(width / 2, 0.5f, length / 2); // Adjust Y to be at the floor level if needed

        // Move the camera to the center of the room
        Camera.main.transform.position = roomCenter + new Vector3(0, 1, 0); // Adjust Y offset as needed to be above the floor

        // Disable the room creation UI
        roomCreationUI.enabled = false;
    }

    void CreatePanel(Vector3 position, Vector3 scale, Color color)
    {
        GameObject panel = Instantiate(wallPrefab, position, Quaternion.identity);
        panel.transform.localScale = scale;
        panel.GetComponent<Renderer>().material.color = color;
    }
}

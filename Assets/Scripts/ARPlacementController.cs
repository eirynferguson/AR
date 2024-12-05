using UnityEngine;
using UnityEngine.UI;


// This script is responsible for switching between different AR prefabs based on UI button selections.
public class ARPlacementController : MonoBehaviour
{
    [SerializeField] private Button craigBtn; // Button to select "Craig" prefab
    [SerializeField] private Button jeffBtn; // Button to select "Jeff" prefab
    [SerializeField] private GameObject[] prefabs; // Array storing prefabs to switch between
    private GameObject placedPrefab; // Reference to the currently placed prefab in the AR scene
    private CharacterManager characterManager; // Reference to the CharacterManager for managing character prefabs

    private void Awake()
    {
        // Find the CharacterManager in the scene and set a reference to it
        characterManager = FindAnyObjectByType<CharacterManager>();

        // Initially select and place the first prefab ("Craig") in the array
        ChangePrefabTo("Craig");

        // Attach listeners to each button, which will call ChangePrefabTo with the corresponding prefab name
        craigBtn.onClick.AddListener(() => ChangePrefabTo("Craig"));
        jeffBtn.onClick.AddListener(() => ChangePrefabTo("Jeff"));
    }

    // Method to switch between prefabs based on the provided prefab name
    void ChangePrefabTo(string prefabName)
    {
        // Check if a prefab with the specified name exists, and if not, log an error
        if (placedPrefab == null)
        {
            Debug.LogError($"Prefab with name {prefabName} could not be loaded. Make sure the prefab name is correct.");
        }

        // Get references to the button colors to visually indicate which prefab is selected
        Color cc = craigBtn.image.color;
        Color jf = jeffBtn.image.color;

        // Switch case to handle prefab selection based on the provided prefab name
        switch (prefabName)
        {
            // The prefabs must be ordered in the prefabs array with "Craig" first and "Jeff" second

            case "Craig":
                cc.a = 1f; // Set full alpha for the "Craig" button, indicating it is selected
                jf.a = 0.5f; // Set half alpha for the "Jeff" button, indicating it is not selected
                characterManager.SwitchPrefab(prefabs[0]); // Switch the current prefab to "Craig"
                break;
            case "Jeff":
                characterManager.SwitchPrefab(prefabs[1]); // Switch the current prefab to "Jeff"
                cc.a = 0.5f; // Set half alpha for the "Craig" button, indicating it is not selected
                jf.a = 1f; // Set full alpha for the "Jeff" button, indicating it is selected
                break;
        }

        // Apply the updated alpha values back to the button images to visually represent selection state
        craigBtn.image.color = cc;
        jeffBtn.image.color = jf;
    }
}







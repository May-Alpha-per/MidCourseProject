using Unity.Cinemachine;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.TextCore.Text;

public class PlayerSwitch : MonoBehaviour
{
    // Assign your characters here in the Unity Inspector
    [SerializeField] private GameObject[] characters; 

    public Transform ActiveCharacter;

    private EnemySword EnemySword;
    private int selectedIndex = 0; // Arrays start at 0 (0 = C1, 1 = C2, 2 = C3)

    public CinemachineCamera CinemachineCam;

    void Start()
    {
        // Ensure only the first character is active at the very beginning of the game
        UpdateCharacterStates(Vector3.zero, Quaternion.identity, isFirstSetup: true);
    }

    void Update()
    {
        // Read spacebar press using the new Input System
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // 1. Save the position and rotation of the character we are currently using
            Vector3 lastPosition = characters[selectedIndex].transform.position;
            Quaternion lastRotation = characters[selectedIndex].transform.rotation;

            // 2. Cycle to the next character index (0 -> 1 -> 2 -> 0)
            selectedIndex = (selectedIndex + 1) % characters.Length;

            // 3. Move the new character to that position and swap which one is active
            UpdateCharacterStates(lastPosition, lastRotation, isFirstSetup: false);
        }
    }

    private void UpdateCharacterStates(Vector3 targetPosition, Quaternion targetRotation, bool isFirstSetup)
    {
        for (int i = 0; i < characters.Length; i++)
        {
            if (characters[i] != null)
            {
                if (i == selectedIndex)
                {
                    // If this is the newly selected character, teleport it before enabling it
                    if (!isFirstSetup)
                    {
                        characters[i].transform.position = targetPosition;
                        characters[i].transform.rotation = targetRotation;
                    }
                    characters[i].SetActive(true);
                    ActiveCharacter = characters[i].transform;
                    // Set the camera to follow the Active character
                    CinemachineCam.Follow = ActiveCharacter;
                    
                    // Update the Active Character for the Enemies to attack
                    EnemySword[] enemies = FindObjectsByType<EnemySword>(FindObjectsSortMode.None);
                    foreach (EnemySword enemy in enemies)
                    {
                        enemy.player = ActiveCharacter;
                    }

                }
                else
                {
                    // Turn off the unselected characters completely
                    characters[i].SetActive(false);
                }
            }
        }
    }

}

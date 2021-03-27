// GENERATED AUTOMATICALLY FROM 'Assets/Script/InputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputSystem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystem"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""d0e00ac9-a10a-4f39-ace1-afb7d55b692b"",
            ""actions"": [
                {
                    ""name"": ""Movements"",
                    ""type"": ""Button"",
                    ""id"": ""7e64a0a3-77ef-4b39-b4b1-82d9fd56359a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""4Movements"",
                    ""type"": ""Value"",
                    ""id"": ""243b1e03-ee74-461e-9ab5-fbda0cf5f1f8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f245566c-8a50-4a93-9f43-b2407a2ca7a6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a48435d1-3fe0-4989-a279-f2e399361d3e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7a791afc-6461-43a0-9d34-02ecdb4fa6f5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""c71b4e77-997d-406c-8a3f-ce6b8099c11b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""4Movements"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e6a994ab-a0b9-41b8-9ade-627eb107978a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""4Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1f68b5ac-c3be-4a19-9b6f-3e2146d1b831"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""4Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f09708e4-4eaf-4f29-ae29-bea1a8497b35"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""4Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""81e2f908-0d28-4aa7-9f51-bc4d07145257"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""4Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movements = m_Player.FindAction("Movements", throwIfNotFound: true);
        m_Player__4Movements = m_Player.FindAction("4Movements", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movements;
    private readonly InputAction m_Player__4Movements;
    public struct PlayerActions
    {
        private @InputSystem m_Wrapper;
        public PlayerActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movements => m_Wrapper.m_Player_Movements;
        public InputAction @_4Movements => m_Wrapper.m_Player__4Movements;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movements.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovements;
                @Movements.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovements;
                @Movements.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovements;
                @_4Movements.started -= m_Wrapper.m_PlayerActionsCallbackInterface.On_4Movements;
                @_4Movements.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.On_4Movements;
                @_4Movements.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.On_4Movements;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movements.started += instance.OnMovements;
                @Movements.performed += instance.OnMovements;
                @Movements.canceled += instance.OnMovements;
                @_4Movements.started += instance.On_4Movements;
                @_4Movements.performed += instance.On_4Movements;
                @_4Movements.canceled += instance.On_4Movements;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMovements(InputAction.CallbackContext context);
        void On_4Movements(InputAction.CallbackContext context);
    }
}

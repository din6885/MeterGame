// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerOne.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerOneInput : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @PlayerOneInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerOne"",
    ""maps"": [
        {
            ""name"": ""PlayerControl"",
            ""id"": ""a35ca842-2196-4b83-9b1b-f380bdd90cf9"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""e0bf7275-0cef-4788-b8c2-a3f4917b84da"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""18fcc8e0-ac49-4eff-b1c6-1cd1159e10f4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cross"",
                    ""type"": ""Button"",
                    ""id"": ""973016d3-348a-4e55-b56c-fb615f849e3b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Square"",
                    ""type"": ""Button"",
                    ""id"": ""dee2a6c5-3e79-4b3e-9822-0fc25770499f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Triangle"",
                    ""type"": ""Button"",
                    ""id"": ""152def54-da89-49ca-ac0d-1f001a2432c1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Circle"",
                    ""type"": ""Button"",
                    ""id"": ""7e368720-123d-4801-a17b-92ff182fd42b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fb8277d4-c5cd-4663-9dc7-ee3f0b506d90"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""6db0ee41-7bf0-46a7-99b8-5f6946795cd1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2272a229-9b46-45dd-97a9-23bbf0a77e40"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3f583389-0285-4ca9-8a32-763779688cf8"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7ca18348-2ae4-412e-bdd1-91cd9e0cf93f"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""184f0198-76f1-47b3-ac23-e8fe6db47d38"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ab651526-af06-43ed-a7a3-c20d9f285a2a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a14beb35-e504-4da6-993a-5319e7323293"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Cross"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da947717-e51f-47d1-a148-f44b46d9578b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Cross"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc32ea83-bfaf-484a-bc82-5b70d346c0d2"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Square"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9989c1d-a84f-486b-9583-91e38eb70095"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Square"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c16732c2-3b65-4fe2-aef4-15c89ab7947c"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Triangle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae631426-5dd9-4aa6-ae53-db15447584a5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Triangle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ddb14e66-75fe-4658-af66-c793e16b82a4"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Circle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c81680d-5a3b-46ab-9670-ae1481760d36"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Circle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerControl
        m_PlayerControl = asset.FindActionMap("PlayerControl", throwIfNotFound: true);
        m_PlayerControl_Navigate = m_PlayerControl.FindAction("Navigate", throwIfNotFound: true);
        m_PlayerControl_Point = m_PlayerControl.FindAction("Point", throwIfNotFound: true);
        m_PlayerControl_Cross = m_PlayerControl.FindAction("Cross", throwIfNotFound: true);
        m_PlayerControl_Square = m_PlayerControl.FindAction("Square", throwIfNotFound: true);
        m_PlayerControl_Triangle = m_PlayerControl.FindAction("Triangle", throwIfNotFound: true);
        m_PlayerControl_Circle = m_PlayerControl.FindAction("Circle", throwIfNotFound: true);
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

    // PlayerControl
    private readonly InputActionMap m_PlayerControl;
    private IPlayerControlActions m_PlayerControlActionsCallbackInterface;
    private readonly InputAction m_PlayerControl_Navigate;
    private readonly InputAction m_PlayerControl_Point;
    private readonly InputAction m_PlayerControl_Cross;
    private readonly InputAction m_PlayerControl_Square;
    private readonly InputAction m_PlayerControl_Triangle;
    private readonly InputAction m_PlayerControl_Circle;
    public struct PlayerControlActions
    {
        private @PlayerOneInput m_Wrapper;
        public PlayerControlActions(@PlayerOneInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_PlayerControl_Navigate;
        public InputAction @Point => m_Wrapper.m_PlayerControl_Point;
        public InputAction @Cross => m_Wrapper.m_PlayerControl_Cross;
        public InputAction @Square => m_Wrapper.m_PlayerControl_Square;
        public InputAction @Triangle => m_Wrapper.m_PlayerControl_Triangle;
        public InputAction @Circle => m_Wrapper.m_PlayerControl_Circle;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlActions instance)
        {
            if (m_Wrapper.m_PlayerControlActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnNavigate;
                @Point.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnPoint;
                @Cross.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnCross;
                @Cross.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnCross;
                @Cross.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnCross;
                @Square.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSquare;
                @Square.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSquare;
                @Square.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSquare;
                @Triangle.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnTriangle;
                @Triangle.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnTriangle;
                @Triangle.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnTriangle;
                @Circle.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnCircle;
                @Circle.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnCircle;
                @Circle.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnCircle;
            }
            m_Wrapper.m_PlayerControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Cross.started += instance.OnCross;
                @Cross.performed += instance.OnCross;
                @Cross.canceled += instance.OnCross;
                @Square.started += instance.OnSquare;
                @Square.performed += instance.OnSquare;
                @Square.canceled += instance.OnSquare;
                @Triangle.started += instance.OnTriangle;
                @Triangle.performed += instance.OnTriangle;
                @Triangle.canceled += instance.OnTriangle;
                @Circle.started += instance.OnCircle;
                @Circle.performed += instance.OnCircle;
                @Circle.canceled += instance.OnCircle;
            }
        }
    }
    public PlayerControlActions @PlayerControl => new PlayerControlActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IPlayerControlActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnCross(InputAction.CallbackContext context);
        void OnSquare(InputAction.CallbackContext context);
        void OnTriangle(InputAction.CallbackContext context);
        void OnCircle(InputAction.CallbackContext context);
    }
}

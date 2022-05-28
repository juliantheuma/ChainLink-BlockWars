//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Controls"",
            ""id"": ""5b2d823c-5dfd-4c17-81ff-c52dc51d2436"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""0aac5d81-3bab-4d2c-aa7c-8c6cf36ed3d9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""58df9d9f-b821-40ca-989a-ce39d4c7e63a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7643e921-318e-48fe-b1b5-222efd70dcf2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Emote1"",
                    ""type"": ""Button"",
                    ""id"": ""4f14f32e-b36d-4a10-9e6c-e784ecf458bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Emote2"",
                    ""type"": ""Button"",
                    ""id"": ""8cd3678f-f1ea-47c7-85af-d17920228187"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Emote3"",
                    ""type"": ""Button"",
                    ""id"": ""b2eaeba6-4f7b-4fb9-ad70-6c7a6dba8215"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Emote4"",
                    ""type"": ""Button"",
                    ""id"": ""6ac36289-d5ff-48bb-aee7-4d47aa362999"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Emote5"",
                    ""type"": ""Button"",
                    ""id"": ""9f69444b-298b-43ef-95aa-ad1e0a1bf55c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""05bcdebb-c807-4f1f-a705-62b477865278"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a2dbd1b-123f-44c5-852f-d2f6f6012619"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b65b49c-ef8e-4380-a9ec-d01d3549d4d5"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""8b7aadfd-ea5d-4afe-9540-64d367dc1352"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""15196c73-a702-4fa5-b2b9-5747e98cda32"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d575d4da-73fe-40f2-8abf-51f6cc7a7005"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fedd0cde-21ef-44f6-8433-ae9cd7403e95"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f10356a6-0230-489f-a7a9-863b4a54efcc"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""acfe611c-c95f-426d-b40b-d1d9f5ed77f1"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a5684f4-8aee-4125-a9d3-21bf01fb3382"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a122659b-fe79-48b8-aa6d-a27917bda8bd"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Emote1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d5abde6-0990-4c63-b4e3-b6c4f6cc2a2f"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Emote2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9404e2fb-87ea-4e79-9b49-f7f4fcd19300"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Emote3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18b1661b-ed8e-4e9c-bff1-e75bcd5c52ff"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Emote4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1c93cd6-c651-433e-9575-6f17e3f25fcf"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Emote5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
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
            ""name"": ""KBM"",
            ""bindingGroup"": ""KBM"",
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
        }
    ]
}");
        // Controls
        m_Controls = asset.FindActionMap("Controls", throwIfNotFound: true);
        m_Controls_Shoot = m_Controls.FindAction("Shoot", throwIfNotFound: true);
        m_Controls_Movement = m_Controls.FindAction("Movement", throwIfNotFound: true);
        m_Controls_Aim = m_Controls.FindAction("Aim", throwIfNotFound: true);
        m_Controls_Emote1 = m_Controls.FindAction("Emote1", throwIfNotFound: true);
        m_Controls_Emote2 = m_Controls.FindAction("Emote2", throwIfNotFound: true);
        m_Controls_Emote3 = m_Controls.FindAction("Emote3", throwIfNotFound: true);
        m_Controls_Emote4 = m_Controls.FindAction("Emote4", throwIfNotFound: true);
        m_Controls_Emote5 = m_Controls.FindAction("Emote5", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Controls
    private readonly InputActionMap m_Controls;
    private IControlsActions m_ControlsActionsCallbackInterface;
    private readonly InputAction m_Controls_Shoot;
    private readonly InputAction m_Controls_Movement;
    private readonly InputAction m_Controls_Aim;
    private readonly InputAction m_Controls_Emote1;
    private readonly InputAction m_Controls_Emote2;
    private readonly InputAction m_Controls_Emote3;
    private readonly InputAction m_Controls_Emote4;
    private readonly InputAction m_Controls_Emote5;
    public struct ControlsActions
    {
        private @PlayerControls m_Wrapper;
        public ControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_Controls_Shoot;
        public InputAction @Movement => m_Wrapper.m_Controls_Movement;
        public InputAction @Aim => m_Wrapper.m_Controls_Aim;
        public InputAction @Emote1 => m_Wrapper.m_Controls_Emote1;
        public InputAction @Emote2 => m_Wrapper.m_Controls_Emote2;
        public InputAction @Emote3 => m_Wrapper.m_Controls_Emote3;
        public InputAction @Emote4 => m_Wrapper.m_Controls_Emote4;
        public InputAction @Emote5 => m_Wrapper.m_Controls_Emote5;
        public InputActionMap Get() { return m_Wrapper.m_Controls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlsActions set) { return set.Get(); }
        public void SetCallbacks(IControlsActions instance)
        {
            if (m_Wrapper.m_ControlsActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnShoot;
                @Movement.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnMovement;
                @Aim.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnAim;
                @Emote1.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnEmote1;
                @Emote1.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnEmote1;
                @Emote1.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnEmote1;
                @Emote2.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnEmote2;
                @Emote2.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnEmote2;
                @Emote2.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnEmote2;
                @Emote3.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnEmote3;
                @Emote3.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnEmote3;
                @Emote3.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnEmote3;
                @Emote4.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnEmote4;
                @Emote4.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnEmote4;
                @Emote4.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnEmote4;
                @Emote5.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnEmote5;
                @Emote5.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnEmote5;
                @Emote5.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnEmote5;
            }
            m_Wrapper.m_ControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Emote1.started += instance.OnEmote1;
                @Emote1.performed += instance.OnEmote1;
                @Emote1.canceled += instance.OnEmote1;
                @Emote2.started += instance.OnEmote2;
                @Emote2.performed += instance.OnEmote2;
                @Emote2.canceled += instance.OnEmote2;
                @Emote3.started += instance.OnEmote3;
                @Emote3.performed += instance.OnEmote3;
                @Emote3.canceled += instance.OnEmote3;
                @Emote4.started += instance.OnEmote4;
                @Emote4.performed += instance.OnEmote4;
                @Emote4.canceled += instance.OnEmote4;
                @Emote5.started += instance.OnEmote5;
                @Emote5.performed += instance.OnEmote5;
                @Emote5.canceled += instance.OnEmote5;
            }
        }
    }
    public ControlsActions @Controls => new ControlsActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KBMSchemeIndex = -1;
    public InputControlScheme KBMScheme
    {
        get
        {
            if (m_KBMSchemeIndex == -1) m_KBMSchemeIndex = asset.FindControlSchemeIndex("KBM");
            return asset.controlSchemes[m_KBMSchemeIndex];
        }
    }
    public interface IControlsActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnEmote1(InputAction.CallbackContext context);
        void OnEmote2(InputAction.CallbackContext context);
        void OnEmote3(InputAction.CallbackContext context);
        void OnEmote4(InputAction.CallbackContext context);
        void OnEmote5(InputAction.CallbackContext context);
    }
}

// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""groundMove"",
            ""id"": ""ec2944f7-5c94-4a1f-a03d-9d984e7e9512"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9fce711e-6fed-4a21-b01c-a227e75d19f1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""f48ae769-139b-4936-8911-4c2d6ae51b61"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""mouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4afcc38a-0019-4ee5-8970-8b5bf675a751"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""mouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2081485e-24ad-4f60-b73b-50cb19977c0e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d37bd51a-b45a-4f76-a454-6f4f53a780f2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8041aaf4-c66f-40ad-a9df-16926f70a781"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""02d701ac-4f2f-4eea-a0fe-57b5d1832d23"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d92f2e66-acc5-4a82-9c4c-43329de234fb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""51543e94-6fc9-4d05-94ed-e8414f689715"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f1bb3b4a-b048-4a2b-afe1-b072730fc6f8"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86ba8918-edf9-4534-9283-45b635629ba7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""072a15da-0cb9-48c0-b834-fd02520d56b6"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32de9ca7-25c4-4f18-a53f-a8dc96e5bd3c"",
                    ""path"": ""<Touchscreen>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d931fa1-eb09-4789-b4fc-35fa91d04691"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf5e53b3-b1ec-4d35-9fcb-6e4aed68140d"",
                    ""path"": ""<Touchscreen>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // groundMove
        m_groundMove = asset.FindActionMap("groundMove", throwIfNotFound: true);
        m_groundMove_move = m_groundMove.FindAction("move", throwIfNotFound: true);
        m_groundMove_Jump = m_groundMove.FindAction("Jump", throwIfNotFound: true);
        m_groundMove_mouseX = m_groundMove.FindAction("mouseX", throwIfNotFound: true);
        m_groundMove_mouseY = m_groundMove.FindAction("mouseY", throwIfNotFound: true);
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

    // groundMove
    private readonly InputActionMap m_groundMove;
    private IGroundMoveActions m_GroundMoveActionsCallbackInterface;
    private readonly InputAction m_groundMove_move;
    private readonly InputAction m_groundMove_Jump;
    private readonly InputAction m_groundMove_mouseX;
    private readonly InputAction m_groundMove_mouseY;
    public struct GroundMoveActions
    {
        private @PlayerInput m_Wrapper;
        public GroundMoveActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_groundMove_move;
        public InputAction @Jump => m_Wrapper.m_groundMove_Jump;
        public InputAction @mouseX => m_Wrapper.m_groundMove_mouseX;
        public InputAction @mouseY => m_Wrapper.m_groundMove_mouseY;
        public InputActionMap Get() { return m_Wrapper.m_groundMove; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GroundMoveActions set) { return set.Get(); }
        public void SetCallbacks(IGroundMoveActions instance)
        {
            if (m_Wrapper.m_GroundMoveActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_GroundMoveActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_GroundMoveActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_GroundMoveActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_GroundMoveActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GroundMoveActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GroundMoveActionsCallbackInterface.OnJump;
                @mouseX.started -= m_Wrapper.m_GroundMoveActionsCallbackInterface.OnMouseX;
                @mouseX.performed -= m_Wrapper.m_GroundMoveActionsCallbackInterface.OnMouseX;
                @mouseX.canceled -= m_Wrapper.m_GroundMoveActionsCallbackInterface.OnMouseX;
                @mouseY.started -= m_Wrapper.m_GroundMoveActionsCallbackInterface.OnMouseY;
                @mouseY.performed -= m_Wrapper.m_GroundMoveActionsCallbackInterface.OnMouseY;
                @mouseY.canceled -= m_Wrapper.m_GroundMoveActionsCallbackInterface.OnMouseY;
            }
            m_Wrapper.m_GroundMoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @mouseX.started += instance.OnMouseX;
                @mouseX.performed += instance.OnMouseX;
                @mouseX.canceled += instance.OnMouseX;
                @mouseY.started += instance.OnMouseY;
                @mouseY.performed += instance.OnMouseY;
                @mouseY.canceled += instance.OnMouseY;
            }
        }
    }
    public GroundMoveActions @groundMove => new GroundMoveActions(this);
    public interface IGroundMoveActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
    }
}

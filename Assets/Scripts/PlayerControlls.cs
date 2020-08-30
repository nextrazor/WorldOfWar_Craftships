// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControlls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControlls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControlls"",
    ""maps"": [
        {
            ""name"": ""PlayerActions"",
            ""id"": ""ea29375d-cbc8-4cf9-b254-c773fbafa9ed"",
            ""actions"": [
                {
                    ""name"": ""Thrust"",
                    ""type"": ""Button"",
                    ""id"": ""20637b35-476e-47e4-88a4-7306e4ee71bf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c6ff95d1-abe3-49b0-a394-9d1a7296685b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Break"",
                    ""type"": ""Button"",
                    ""id"": ""60f03373-1367-4e61-a28a-80370b2755f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootL"",
                    ""type"": ""Button"",
                    ""id"": ""427a275a-d447-4722-a8cc-fd54dfc0e47a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShoorR"",
                    ""type"": ""Button"",
                    ""id"": ""2f786e89-1e14-49ab-b726-3d5cdc5f8eb8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpeedBoost"",
                    ""type"": ""Button"",
                    ""id"": ""89d7b243-62d3-414d-8379-50a9033447bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootLeftCannon"",
                    ""type"": ""Button"",
                    ""id"": ""3eefa1a4-eaea-4229-9783-8557376d27e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootRightCannon"",
                    ""type"": ""Button"",
                    ""id"": ""103f5f51-779d-4191-9c35-4ea5c8ff51d9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ElfShield"",
                    ""type"": ""Button"",
                    ""id"": ""5b5e2db1-ed3f-4093-bae6-84977de5e270"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c4138f92-6c9a-4c97-a3e7-5d5bf2022239"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""1665c273-d9ae-4bb3-9f2b-a18accff85f5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8e126a43-ab94-43fb-af37-d24f57f795b2"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e66dcdf7-b036-4e4c-ae4b-a78da86a6e87"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f139b0d2-456d-4aa1-ac1f-56acd2f2cb93"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""629d023e-df32-4dcb-851c-045e46622c2f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5e917603-1813-4f43-bfc9-77705ceb0745"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd17c7e5-7365-4866-a027-1fdb0cb83038"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Hold,Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0bec29fe-c9c4-423f-a594-7e034a236ba1"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": ""Hold,Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShoorR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2318a594-32cc-4b5c-a5f7-77f038128ad1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpeedBoost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eaa34401-fa50-4e53-9fb0-52de74d37f91"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootLeftCannon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b799f95-9747-4377-8440-a5808cb53408"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootRightCannon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6a3ab07-2f2b-4569-a927-e29cfaf6c891"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ElfShield"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerActions
        m_PlayerActions = asset.FindActionMap("PlayerActions", throwIfNotFound: true);
        m_PlayerActions_Thrust = m_PlayerActions.FindAction("Thrust", throwIfNotFound: true);
        m_PlayerActions_Rotate = m_PlayerActions.FindAction("Rotate", throwIfNotFound: true);
        m_PlayerActions_Break = m_PlayerActions.FindAction("Break", throwIfNotFound: true);
        m_PlayerActions_ShootL = m_PlayerActions.FindAction("ShootL", throwIfNotFound: true);
        m_PlayerActions_ShoorR = m_PlayerActions.FindAction("ShoorR", throwIfNotFound: true);
        m_PlayerActions_SpeedBoost = m_PlayerActions.FindAction("SpeedBoost", throwIfNotFound: true);
        m_PlayerActions_ShootLeftCannon = m_PlayerActions.FindAction("ShootLeftCannon", throwIfNotFound: true);
        m_PlayerActions_ShootRightCannon = m_PlayerActions.FindAction("ShootRightCannon", throwIfNotFound: true);
        m_PlayerActions_ElfShield = m_PlayerActions.FindAction("ElfShield", throwIfNotFound: true);
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

    // PlayerActions
    private readonly InputActionMap m_PlayerActions;
    private IPlayerActionsActions m_PlayerActionsActionsCallbackInterface;
    private readonly InputAction m_PlayerActions_Thrust;
    private readonly InputAction m_PlayerActions_Rotate;
    private readonly InputAction m_PlayerActions_Break;
    private readonly InputAction m_PlayerActions_ShootL;
    private readonly InputAction m_PlayerActions_ShoorR;
    private readonly InputAction m_PlayerActions_SpeedBoost;
    private readonly InputAction m_PlayerActions_ShootLeftCannon;
    private readonly InputAction m_PlayerActions_ShootRightCannon;
    private readonly InputAction m_PlayerActions_ElfShield;
    public struct PlayerActionsActions
    {
        private @PlayerControlls m_Wrapper;
        public PlayerActionsActions(@PlayerControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Thrust => m_Wrapper.m_PlayerActions_Thrust;
        public InputAction @Rotate => m_Wrapper.m_PlayerActions_Rotate;
        public InputAction @Break => m_Wrapper.m_PlayerActions_Break;
        public InputAction @ShootL => m_Wrapper.m_PlayerActions_ShootL;
        public InputAction @ShoorR => m_Wrapper.m_PlayerActions_ShoorR;
        public InputAction @SpeedBoost => m_Wrapper.m_PlayerActions_SpeedBoost;
        public InputAction @ShootLeftCannon => m_Wrapper.m_PlayerActions_ShootLeftCannon;
        public InputAction @ShootRightCannon => m_Wrapper.m_PlayerActions_ShootRightCannon;
        public InputAction @ElfShield => m_Wrapper.m_PlayerActions_ElfShield;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterface != null)
            {
                @Thrust.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnThrust;
                @Thrust.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnThrust;
                @Thrust.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnThrust;
                @Rotate.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRotate;
                @Break.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnBreak;
                @Break.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnBreak;
                @Break.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnBreak;
                @ShootL.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnShootL;
                @ShootL.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnShootL;
                @ShootL.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnShootL;
                @ShoorR.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnShoorR;
                @ShoorR.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnShoorR;
                @ShoorR.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnShoorR;
                @SpeedBoost.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnSpeedBoost;
                @SpeedBoost.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnSpeedBoost;
                @SpeedBoost.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnSpeedBoost;
                @ShootLeftCannon.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnShootLeftCannon;
                @ShootLeftCannon.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnShootLeftCannon;
                @ShootLeftCannon.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnShootLeftCannon;
                @ShootRightCannon.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnShootRightCannon;
                @ShootRightCannon.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnShootRightCannon;
                @ShootRightCannon.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnShootRightCannon;
                @ElfShield.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnElfShield;
                @ElfShield.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnElfShield;
                @ElfShield.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnElfShield;
            }
            m_Wrapper.m_PlayerActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Thrust.started += instance.OnThrust;
                @Thrust.performed += instance.OnThrust;
                @Thrust.canceled += instance.OnThrust;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Break.started += instance.OnBreak;
                @Break.performed += instance.OnBreak;
                @Break.canceled += instance.OnBreak;
                @ShootL.started += instance.OnShootL;
                @ShootL.performed += instance.OnShootL;
                @ShootL.canceled += instance.OnShootL;
                @ShoorR.started += instance.OnShoorR;
                @ShoorR.performed += instance.OnShoorR;
                @ShoorR.canceled += instance.OnShoorR;
                @SpeedBoost.started += instance.OnSpeedBoost;
                @SpeedBoost.performed += instance.OnSpeedBoost;
                @SpeedBoost.canceled += instance.OnSpeedBoost;
                @ShootLeftCannon.started += instance.OnShootLeftCannon;
                @ShootLeftCannon.performed += instance.OnShootLeftCannon;
                @ShootLeftCannon.canceled += instance.OnShootLeftCannon;
                @ShootRightCannon.started += instance.OnShootRightCannon;
                @ShootRightCannon.performed += instance.OnShootRightCannon;
                @ShootRightCannon.canceled += instance.OnShootRightCannon;
                @ElfShield.started += instance.OnElfShield;
                @ElfShield.performed += instance.OnElfShield;
                @ElfShield.canceled += instance.OnElfShield;
            }
        }
    }
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);
    public interface IPlayerActionsActions
    {
        void OnThrust(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnBreak(InputAction.CallbackContext context);
        void OnShootL(InputAction.CallbackContext context);
        void OnShoorR(InputAction.CallbackContext context);
        void OnSpeedBoost(InputAction.CallbackContext context);
        void OnShootLeftCannon(InputAction.CallbackContext context);
        void OnShootRightCannon(InputAction.CallbackContext context);
        void OnElfShield(InputAction.CallbackContext context);
    }
}

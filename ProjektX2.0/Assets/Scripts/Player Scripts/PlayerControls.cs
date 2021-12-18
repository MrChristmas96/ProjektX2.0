// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActionControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActionControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player1"",
            ""id"": ""65a7ee78-6adf-4ed5-919d-9cfe9d5d516c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8d97cdfe-491d-415d-807c-c1a382e9d515"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""49c6d44a-cd7d-4d94-84f1-cc7144723263"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2972765a-90eb-4ac5-8d37-d8f4a66bf110"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Send"",
                    ""type"": ""Button"",
                    ""id"": ""c822f031-3753-4e08-848f-241519d8f3f7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Stun"",
                    ""type"": ""Button"",
                    ""id"": ""4c242048-12c6-48c7-9757-d9976173f094"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Sideways"",
                    ""id"": ""45b3a6da-d1b7-4ec3-8aad-73bb1d88366e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f6cb2dcd-c61d-453b-ba9d-607eea29938b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""11a1a6bd-4e1a-4b35-87dd-ae71a8602a54"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""90956f64-9943-4dca-8b20-db736d0384fb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91b8d449-8864-428d-aeae-7fb28d75d346"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db41d59e-8747-4c0d-865d-e2c0154e5c96"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Send"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af0fa59c-d668-447c-8da7-690dafbaf7cb"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""f8eae742-52e4-48df-aaa3-d7b973ea579d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""86d19638-b047-4757-b8cb-a3c000a70bc4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""d8861e2b-b7e0-4871-8479-18b3a44e4f4e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""6c153b17-8a57-4e72-9077-23e462e89dfb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Send"",
                    ""type"": ""Button"",
                    ""id"": ""aceecda4-b96a-440f-9558-7e520ad4a178"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Stun"",
                    ""type"": ""Button"",
                    ""id"": ""1026c14e-0903-4076-ab37-2796eed63714"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Sideways"",
                    ""id"": ""17a64b30-39d6-46c4-bdcb-3a7cd09c0332"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c63dafb8-914a-4835-a921-f7fbcfdddbd8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3be834ce-d89a-4018-b5e1-aa7f360cc975"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3a646dc0-3b30-4286-aef5-40ffec4e54ce"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5e81375-a901-40fb-808b-2d2c966a8bc2"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b70bac1-cd23-487c-adc3-2cb05dc88ec1"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Send"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6eacad3-38a7-4684-9883-3d7447af7471"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Esc"",
            ""id"": ""c0b083a0-59ee-474d-ba50-96501aeba1d5"",
            ""actions"": [
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""468a8c1e-6086-41be-9e8f-936a45e07024"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3773ebe2-7f44-496b-8ca3-48679e6b333a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_Move = m_Player1.FindAction("Move", throwIfNotFound: true);
        m_Player1_Jump = m_Player1.FindAction("Jump", throwIfNotFound: true);
        m_Player1_Attack = m_Player1.FindAction("Attack", throwIfNotFound: true);
        m_Player1_Send = m_Player1.FindAction("Send", throwIfNotFound: true);
        m_Player1_Stun = m_Player1.FindAction("Stun", throwIfNotFound: true);
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_Move = m_Player2.FindAction("Move", throwIfNotFound: true);
        m_Player2_Jump = m_Player2.FindAction("Jump", throwIfNotFound: true);
        m_Player2_Attack = m_Player2.FindAction("Attack", throwIfNotFound: true);
        m_Player2_Send = m_Player2.FindAction("Send", throwIfNotFound: true);
        m_Player2_Stun = m_Player2.FindAction("Stun", throwIfNotFound: true);
        // Esc
        m_Esc = asset.FindActionMap("Esc", throwIfNotFound: true);
        m_Esc_Menu = m_Esc.FindAction("Menu", throwIfNotFound: true);
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

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_Move;
    private readonly InputAction m_Player1_Jump;
    private readonly InputAction m_Player1_Attack;
    private readonly InputAction m_Player1_Send;
    private readonly InputAction m_Player1_Stun;
    public struct Player1Actions
    {
        private @PlayerActionControls m_Wrapper;
        public Player1Actions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player1_Move;
        public InputAction @Jump => m_Wrapper.m_Player1_Jump;
        public InputAction @Attack => m_Wrapper.m_Player1_Attack;
        public InputAction @Send => m_Wrapper.m_Player1_Send;
        public InputAction @Stun => m_Wrapper.m_Player1_Stun;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnJump;
                @Attack.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAttack;
                @Send.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnSend;
                @Send.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnSend;
                @Send.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnSend;
                @Stun.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnStun;
                @Stun.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnStun;
                @Stun.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnStun;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Send.started += instance.OnSend;
                @Send.performed += instance.OnSend;
                @Send.canceled += instance.OnSend;
                @Stun.started += instance.OnStun;
                @Stun.performed += instance.OnStun;
                @Stun.canceled += instance.OnStun;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_Move;
    private readonly InputAction m_Player2_Jump;
    private readonly InputAction m_Player2_Attack;
    private readonly InputAction m_Player2_Send;
    private readonly InputAction m_Player2_Stun;
    public struct Player2Actions
    {
        private @PlayerActionControls m_Wrapper;
        public Player2Actions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player2_Move;
        public InputAction @Jump => m_Wrapper.m_Player2_Jump;
        public InputAction @Attack => m_Wrapper.m_Player2_Attack;
        public InputAction @Send => m_Wrapper.m_Player2_Send;
        public InputAction @Stun => m_Wrapper.m_Player2_Stun;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnJump;
                @Attack.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAttack;
                @Send.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnSend;
                @Send.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnSend;
                @Send.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnSend;
                @Stun.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnStun;
                @Stun.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnStun;
                @Stun.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnStun;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Send.started += instance.OnSend;
                @Send.performed += instance.OnSend;
                @Send.canceled += instance.OnSend;
                @Stun.started += instance.OnStun;
                @Stun.performed += instance.OnStun;
                @Stun.canceled += instance.OnStun;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);

    // Esc
    private readonly InputActionMap m_Esc;
    private IEscActions m_EscActionsCallbackInterface;
    private readonly InputAction m_Esc_Menu;
    public struct EscActions
    {
        private @PlayerActionControls m_Wrapper;
        public EscActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Menu => m_Wrapper.m_Esc_Menu;
        public InputActionMap Get() { return m_Wrapper.m_Esc; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EscActions set) { return set.Get(); }
        public void SetCallbacks(IEscActions instance)
        {
            if (m_Wrapper.m_EscActionsCallbackInterface != null)
            {
                @Menu.started -= m_Wrapper.m_EscActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_EscActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_EscActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_EscActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public EscActions @Esc => new EscActions(this);
    public interface IPlayer1Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnSend(InputAction.CallbackContext context);
        void OnStun(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnSend(InputAction.CallbackContext context);
        void OnStun(InputAction.CallbackContext context);
    }
    public interface IEscActions
    {
        void OnMenu(InputAction.CallbackContext context);
    }
}

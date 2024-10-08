//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/1.Scripts/Player/PlayerInput.inputactions
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

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""PlayerMovement"",
            ""id"": ""5225e8ff-5375-4fe5-bb93-9efb43c9d504"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""d87da26b-7f77-4a8e-8546-bc8c178bd056"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""287e6839-4fb3-4916-ad5d-3cfe52c4f20b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Defence"",
                    ""type"": ""Button"",
                    ""id"": ""01a8f11c-7e8d-4514-a2a2-5a2a8654711b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""9325c032-b24e-49bc-9ad7-d4704d066811"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""7b615213-92aa-46e1-8ce0-b54ced3af220"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Draw&Sheath"",
                    ""type"": ""Button"",
                    ""id"": ""a69797b1-a8f5-4b19-b9c1-fff8ddbf9573"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""BowDraw"",
                    ""type"": ""Button"",
                    ""id"": ""c731a5a5-4c43-4f5e-8202-f46e81e632ee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SpearDraw"",
                    ""type"": ""Button"",
                    ""id"": ""4f909872-8441-46c1-b0b1-8b470887e03e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""49e567e1-d681-476c-af56-ae5929b39820"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2673ff22-09d0-4868-b9bc-757a3d7a21d5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f89a14be-0e68-44e1-b814-bcc82df36209"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7a5ac179-cb5e-4fa7-8096-a1839c881ac4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""350ddb91-90e4-459d-9aec-2f30e35b88f0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""01002c73-3e6d-4c4f-9408-40ab2684943e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92f7c282-eb89-4fa0-b34d-c3c276461ba6"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Defence"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6770013d-27d0-47d7-9728-02b0f1ae7082"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d574f9f7-8e79-42e1-8eec-796a5008281e"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15414238-904a-413e-aa1a-e10aa5c01ead"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Draw&Sheath"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4db35bf-7119-45f1-bdcf-1da60ebaadca"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""BowDraw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3910d49-6c20-448f-920f-cafd61fcbb2e"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""SpearDraw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerMouseAndinterfact"",
            ""id"": ""3fcadfa9-df2f-43d9-a2cd-2608c9519acc"",
            ""actions"": [
                {
                    ""name"": ""InventoryOpen"",
                    ""type"": ""Button"",
                    ""id"": ""7eeb7c5a-c2f9-4b46-9530-a170ded932e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AllClose"",
                    ""type"": ""Button"",
                    ""id"": ""277c4bd3-1b81-41b1-8878-d53db41647a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4816c094-7ad6-41cd-b3ea-503cd096bd45"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""InventoryOpen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0464ad46-447a-4f95-b47f-384d4e3017b6"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""AllClose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerSkills"",
            ""id"": ""8624df98-5cff-4b2c-9617-8cd3d0e2c81c"",
            ""actions"": [
                {
                    ""name"": ""Skill1"",
                    ""type"": ""Button"",
                    ""id"": ""628f2344-fa80-4d96-94bb-60609942fb88"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Skill2"",
                    ""type"": ""Button"",
                    ""id"": ""042145fb-f85e-405f-ac7a-3bd6c563a551"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Skill3"",
                    ""type"": ""Button"",
                    ""id"": ""21f0dfb4-ad19-4e84-a715-0422ce12c0b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b4e02568-cb44-412a-8f28-3f1c13df0ada"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ebdc7b0-a630-4081-a0da-645531330a05"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""290e3d5f-c7cd-455d-8e95-2eddb4f58c17"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill3"",
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
        }
    ]
}");
        // PlayerMovement
        m_PlayerMovement = asset.FindActionMap("PlayerMovement", throwIfNotFound: true);
        m_PlayerMovement_Move = m_PlayerMovement.FindAction("Move", throwIfNotFound: true);
        m_PlayerMovement_Attack = m_PlayerMovement.FindAction("Attack", throwIfNotFound: true);
        m_PlayerMovement_Defence = m_PlayerMovement.FindAction("Defence", throwIfNotFound: true);
        m_PlayerMovement_Run = m_PlayerMovement.FindAction("Run", throwIfNotFound: true);
        m_PlayerMovement_Interaction = m_PlayerMovement.FindAction("Interaction", throwIfNotFound: true);
        m_PlayerMovement_DrawSheath = m_PlayerMovement.FindAction("Draw&Sheath", throwIfNotFound: true);
        m_PlayerMovement_BowDraw = m_PlayerMovement.FindAction("BowDraw", throwIfNotFound: true);
        m_PlayerMovement_SpearDraw = m_PlayerMovement.FindAction("SpearDraw", throwIfNotFound: true);
        // PlayerMouseAndinterfact
        m_PlayerMouseAndinterfact = asset.FindActionMap("PlayerMouseAndinterfact", throwIfNotFound: true);
        m_PlayerMouseAndinterfact_InventoryOpen = m_PlayerMouseAndinterfact.FindAction("InventoryOpen", throwIfNotFound: true);
        m_PlayerMouseAndinterfact_AllClose = m_PlayerMouseAndinterfact.FindAction("AllClose", throwIfNotFound: true);
        // PlayerSkills
        m_PlayerSkills = asset.FindActionMap("PlayerSkills", throwIfNotFound: true);
        m_PlayerSkills_Skill1 = m_PlayerSkills.FindAction("Skill1", throwIfNotFound: true);
        m_PlayerSkills_Skill2 = m_PlayerSkills.FindAction("Skill2", throwIfNotFound: true);
        m_PlayerSkills_Skill3 = m_PlayerSkills.FindAction("Skill3", throwIfNotFound: true);
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

    // PlayerMovement
    private readonly InputActionMap m_PlayerMovement;
    private List<IPlayerMovementActions> m_PlayerMovementActionsCallbackInterfaces = new List<IPlayerMovementActions>();
    private readonly InputAction m_PlayerMovement_Move;
    private readonly InputAction m_PlayerMovement_Attack;
    private readonly InputAction m_PlayerMovement_Defence;
    private readonly InputAction m_PlayerMovement_Run;
    private readonly InputAction m_PlayerMovement_Interaction;
    private readonly InputAction m_PlayerMovement_DrawSheath;
    private readonly InputAction m_PlayerMovement_BowDraw;
    private readonly InputAction m_PlayerMovement_SpearDraw;
    public struct PlayerMovementActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerMovementActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerMovement_Move;
        public InputAction @Attack => m_Wrapper.m_PlayerMovement_Attack;
        public InputAction @Defence => m_Wrapper.m_PlayerMovement_Defence;
        public InputAction @Run => m_Wrapper.m_PlayerMovement_Run;
        public InputAction @Interaction => m_Wrapper.m_PlayerMovement_Interaction;
        public InputAction @DrawSheath => m_Wrapper.m_PlayerMovement_DrawSheath;
        public InputAction @BowDraw => m_Wrapper.m_PlayerMovement_BowDraw;
        public InputAction @SpearDraw => m_Wrapper.m_PlayerMovement_SpearDraw;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Attack.started += instance.OnAttack;
            @Attack.performed += instance.OnAttack;
            @Attack.canceled += instance.OnAttack;
            @Defence.started += instance.OnDefence;
            @Defence.performed += instance.OnDefence;
            @Defence.canceled += instance.OnDefence;
            @Run.started += instance.OnRun;
            @Run.performed += instance.OnRun;
            @Run.canceled += instance.OnRun;
            @Interaction.started += instance.OnInteraction;
            @Interaction.performed += instance.OnInteraction;
            @Interaction.canceled += instance.OnInteraction;
            @DrawSheath.started += instance.OnDrawSheath;
            @DrawSheath.performed += instance.OnDrawSheath;
            @DrawSheath.canceled += instance.OnDrawSheath;
            @BowDraw.started += instance.OnBowDraw;
            @BowDraw.performed += instance.OnBowDraw;
            @BowDraw.canceled += instance.OnBowDraw;
            @SpearDraw.started += instance.OnSpearDraw;
            @SpearDraw.performed += instance.OnSpearDraw;
            @SpearDraw.canceled += instance.OnSpearDraw;
        }

        private void UnregisterCallbacks(IPlayerMovementActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Attack.started -= instance.OnAttack;
            @Attack.performed -= instance.OnAttack;
            @Attack.canceled -= instance.OnAttack;
            @Defence.started -= instance.OnDefence;
            @Defence.performed -= instance.OnDefence;
            @Defence.canceled -= instance.OnDefence;
            @Run.started -= instance.OnRun;
            @Run.performed -= instance.OnRun;
            @Run.canceled -= instance.OnRun;
            @Interaction.started -= instance.OnInteraction;
            @Interaction.performed -= instance.OnInteraction;
            @Interaction.canceled -= instance.OnInteraction;
            @DrawSheath.started -= instance.OnDrawSheath;
            @DrawSheath.performed -= instance.OnDrawSheath;
            @DrawSheath.canceled -= instance.OnDrawSheath;
            @BowDraw.started -= instance.OnBowDraw;
            @BowDraw.performed -= instance.OnBowDraw;
            @BowDraw.canceled -= instance.OnBowDraw;
            @SpearDraw.started -= instance.OnSpearDraw;
            @SpearDraw.performed -= instance.OnSpearDraw;
            @SpearDraw.canceled -= instance.OnSpearDraw;
        }

        public void RemoveCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerMovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // PlayerMouseAndinterfact
    private readonly InputActionMap m_PlayerMouseAndinterfact;
    private List<IPlayerMouseAndinterfactActions> m_PlayerMouseAndinterfactActionsCallbackInterfaces = new List<IPlayerMouseAndinterfactActions>();
    private readonly InputAction m_PlayerMouseAndinterfact_InventoryOpen;
    private readonly InputAction m_PlayerMouseAndinterfact_AllClose;
    public struct PlayerMouseAndinterfactActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerMouseAndinterfactActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @InventoryOpen => m_Wrapper.m_PlayerMouseAndinterfact_InventoryOpen;
        public InputAction @AllClose => m_Wrapper.m_PlayerMouseAndinterfact_AllClose;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMouseAndinterfact; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMouseAndinterfactActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerMouseAndinterfactActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerMouseAndinterfactActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerMouseAndinterfactActionsCallbackInterfaces.Add(instance);
            @InventoryOpen.started += instance.OnInventoryOpen;
            @InventoryOpen.performed += instance.OnInventoryOpen;
            @InventoryOpen.canceled += instance.OnInventoryOpen;
            @AllClose.started += instance.OnAllClose;
            @AllClose.performed += instance.OnAllClose;
            @AllClose.canceled += instance.OnAllClose;
        }

        private void UnregisterCallbacks(IPlayerMouseAndinterfactActions instance)
        {
            @InventoryOpen.started -= instance.OnInventoryOpen;
            @InventoryOpen.performed -= instance.OnInventoryOpen;
            @InventoryOpen.canceled -= instance.OnInventoryOpen;
            @AllClose.started -= instance.OnAllClose;
            @AllClose.performed -= instance.OnAllClose;
            @AllClose.canceled -= instance.OnAllClose;
        }

        public void RemoveCallbacks(IPlayerMouseAndinterfactActions instance)
        {
            if (m_Wrapper.m_PlayerMouseAndinterfactActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerMouseAndinterfactActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerMouseAndinterfactActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerMouseAndinterfactActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerMouseAndinterfactActions @PlayerMouseAndinterfact => new PlayerMouseAndinterfactActions(this);

    // PlayerSkills
    private readonly InputActionMap m_PlayerSkills;
    private List<IPlayerSkillsActions> m_PlayerSkillsActionsCallbackInterfaces = new List<IPlayerSkillsActions>();
    private readonly InputAction m_PlayerSkills_Skill1;
    private readonly InputAction m_PlayerSkills_Skill2;
    private readonly InputAction m_PlayerSkills_Skill3;
    public struct PlayerSkillsActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerSkillsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Skill1 => m_Wrapper.m_PlayerSkills_Skill1;
        public InputAction @Skill2 => m_Wrapper.m_PlayerSkills_Skill2;
        public InputAction @Skill3 => m_Wrapper.m_PlayerSkills_Skill3;
        public InputActionMap Get() { return m_Wrapper.m_PlayerSkills; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerSkillsActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerSkillsActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerSkillsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerSkillsActionsCallbackInterfaces.Add(instance);
            @Skill1.started += instance.OnSkill1;
            @Skill1.performed += instance.OnSkill1;
            @Skill1.canceled += instance.OnSkill1;
            @Skill2.started += instance.OnSkill2;
            @Skill2.performed += instance.OnSkill2;
            @Skill2.canceled += instance.OnSkill2;
            @Skill3.started += instance.OnSkill3;
            @Skill3.performed += instance.OnSkill3;
            @Skill3.canceled += instance.OnSkill3;
        }

        private void UnregisterCallbacks(IPlayerSkillsActions instance)
        {
            @Skill1.started -= instance.OnSkill1;
            @Skill1.performed -= instance.OnSkill1;
            @Skill1.canceled -= instance.OnSkill1;
            @Skill2.started -= instance.OnSkill2;
            @Skill2.performed -= instance.OnSkill2;
            @Skill2.canceled -= instance.OnSkill2;
            @Skill3.started -= instance.OnSkill3;
            @Skill3.performed -= instance.OnSkill3;
            @Skill3.canceled -= instance.OnSkill3;
        }

        public void RemoveCallbacks(IPlayerSkillsActions instance)
        {
            if (m_Wrapper.m_PlayerSkillsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerSkillsActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerSkillsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerSkillsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerSkillsActions @PlayerSkills => new PlayerSkillsActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IPlayerMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnDefence(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
        void OnDrawSheath(InputAction.CallbackContext context);
        void OnBowDraw(InputAction.CallbackContext context);
        void OnSpearDraw(InputAction.CallbackContext context);
    }
    public interface IPlayerMouseAndinterfactActions
    {
        void OnInventoryOpen(InputAction.CallbackContext context);
        void OnAllClose(InputAction.CallbackContext context);
    }
    public interface IPlayerSkillsActions
    {
        void OnSkill1(InputAction.CallbackContext context);
        void OnSkill2(InputAction.CallbackContext context);
        void OnSkill3(InputAction.CallbackContext context);
    }
}

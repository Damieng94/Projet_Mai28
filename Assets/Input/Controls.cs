// GENERATED AUTOMATICALLY FROM 'Assets/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Deplacement"",
            ""id"": ""e10f0591-c73d-4ca8-9c1f-1f242b636bf2"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8414cc8d-a9c0-40f1-b0b2-cbeaffaae25f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLR"",
                    ""type"": ""Button"",
                    ""id"": ""feb2b08b-ff77-435a-a443-03caa7b00008"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a80dcf97-8783-4de2-bb92-5d82276e6a5f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""de365773-aef9-4523-ad93-50026e090aaa"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLR"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""cdbfbda6-ec02-4287-9611-30e17a5d1a25"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6f34dae8-b205-43ed-ba47-8c896a14c922"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Deplacement
        m_Deplacement = asset.FindActionMap("Deplacement", throwIfNotFound: true);
        m_Deplacement_Jump = m_Deplacement.FindAction("Jump", throwIfNotFound: true);
        m_Deplacement_MoveLR = m_Deplacement.FindAction("MoveLR", throwIfNotFound: true);
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

    // Deplacement
    private readonly InputActionMap m_Deplacement;
    private IDeplacementActions m_DeplacementActionsCallbackInterface;
    private readonly InputAction m_Deplacement_Jump;
    private readonly InputAction m_Deplacement_MoveLR;
    public struct DeplacementActions
    {
        private @Controls m_Wrapper;
        public DeplacementActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Deplacement_Jump;
        public InputAction @MoveLR => m_Wrapper.m_Deplacement_MoveLR;
        public InputActionMap Get() { return m_Wrapper.m_Deplacement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DeplacementActions set) { return set.Get(); }
        public void SetCallbacks(IDeplacementActions instance)
        {
            if (m_Wrapper.m_DeplacementActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_DeplacementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_DeplacementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_DeplacementActionsCallbackInterface.OnJump;
                @MoveLR.started -= m_Wrapper.m_DeplacementActionsCallbackInterface.OnMoveLR;
                @MoveLR.performed -= m_Wrapper.m_DeplacementActionsCallbackInterface.OnMoveLR;
                @MoveLR.canceled -= m_Wrapper.m_DeplacementActionsCallbackInterface.OnMoveLR;
            }
            m_Wrapper.m_DeplacementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MoveLR.started += instance.OnMoveLR;
                @MoveLR.performed += instance.OnMoveLR;
                @MoveLR.canceled += instance.OnMoveLR;
            }
        }
    }
    public DeplacementActions @Deplacement => new DeplacementActions(this);
    public interface IDeplacementActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMoveLR(InputAction.CallbackContext context);
    }
}

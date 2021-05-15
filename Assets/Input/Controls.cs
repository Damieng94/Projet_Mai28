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
                    ""name"": ""Space"",
                    ""type"": ""Button"",
                    ""id"": ""8414cc8d-a9c0-40f1-b0b2-cbeaffaae25f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftRight"",
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
                    ""action"": ""Space"",
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
                    ""action"": ""LeftRight"",
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
                    ""action"": ""LeftRight"",
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
                    ""action"": ""LeftRight"",
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
        m_Deplacement_Space = m_Deplacement.FindAction("Space", throwIfNotFound: true);
        m_Deplacement_LeftRight = m_Deplacement.FindAction("LeftRight", throwIfNotFound: true);
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
    private readonly InputAction m_Deplacement_Space;
    private readonly InputAction m_Deplacement_LeftRight;
    public struct DeplacementActions
    {
        private @Controls m_Wrapper;
        public DeplacementActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Space => m_Wrapper.m_Deplacement_Space;
        public InputAction @LeftRight => m_Wrapper.m_Deplacement_LeftRight;
        public InputActionMap Get() { return m_Wrapper.m_Deplacement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DeplacementActions set) { return set.Get(); }
        public void SetCallbacks(IDeplacementActions instance)
        {
            if (m_Wrapper.m_DeplacementActionsCallbackInterface != null)
            {
                @Space.started -= m_Wrapper.m_DeplacementActionsCallbackInterface.OnSpace;
                @Space.performed -= m_Wrapper.m_DeplacementActionsCallbackInterface.OnSpace;
                @Space.canceled -= m_Wrapper.m_DeplacementActionsCallbackInterface.OnSpace;
                @LeftRight.started -= m_Wrapper.m_DeplacementActionsCallbackInterface.OnLeftRight;
                @LeftRight.performed -= m_Wrapper.m_DeplacementActionsCallbackInterface.OnLeftRight;
                @LeftRight.canceled -= m_Wrapper.m_DeplacementActionsCallbackInterface.OnLeftRight;
            }
            m_Wrapper.m_DeplacementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Space.started += instance.OnSpace;
                @Space.performed += instance.OnSpace;
                @Space.canceled += instance.OnSpace;
                @LeftRight.started += instance.OnLeftRight;
                @LeftRight.performed += instance.OnLeftRight;
                @LeftRight.canceled += instance.OnLeftRight;
            }
        }
    }
    public DeplacementActions @Deplacement => new DeplacementActions(this);
    public interface IDeplacementActions
    {
        void OnSpace(InputAction.CallbackContext context);
        void OnLeftRight(InputAction.CallbackContext context);
    }
}

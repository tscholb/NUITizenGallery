﻿using System;
using System.Collections.Generic;
using Tizen;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;

namespace NUITizenGallery
{
    internal class RadioButtonTestPage1 : ContentPage
    {
        private View root;

        private View left;
        private View right;
        private View leftbody;
        private View rightbody;

        private TextLabel[] createText = new TextLabel[2];
        private TextLabel[] modeText = new TextLabel[4];
        private TextLabel[] modeText2 = new TextLabel[4];
        private TextLabel groupInfo;

        private RadioButton[] utilityRadioButton = new RadioButton[4];
        private RadioButton[] familyRadioButton = new RadioButton[4];
        private RadioButton[] foodRadioButton = new RadioButton[4];
        private RadioButton[] kitchenRadioButton = new RadioButton[4];
        private RadioButtonGroup[] group = new RadioButtonGroup[4];

        private RadioButton[] utilityRadioButton2 = new RadioButton[4];
        private RadioButton[] familyRadioButton2 = new RadioButton[4];
        private RadioButton[] foodRadioButton2 = new RadioButton[4];
        private RadioButton[] kitchenRadioButton2 = new RadioButton[4];
        private RadioButtonGroup[] group2 = new RadioButtonGroup[4];
        
        private static string ResourcePath = Tizen.Applications.Application.Current.DirectoryInfo.Resource + "/images/";

        private static string[] mode = new string[]
        {
            "Utility",
            "Family",
            "Food",
            "Kitchen",
        };

        internal RadioButtonTestPage1(Window window)
        {
            AppBar = new AppBar()
            {
                Title = "RadioButton Sample",
            };

            root = new View()
            {
                Size = new Size(window.WindowSize.Width, window.WindowSize.Height),
                BackgroundColor = new Color(0.7f, 0.9f, 0.8f, 1.0f),
                Layout = new LinearLayout()
                {
                    LinearOrientation = LinearLayout.Orientation.Horizontal,
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    CellPadding = new Size(10, 50),
                }
            };

            ///////////////////////////////////////////////Create by Property//////////////////////////////////////////////////////////
            left = new View()
            {
                Size = new Size(window.WindowSize.Width / 2, window.WindowSize.Height * 3 / 4),
                Layout = new LinearLayout()
                {
                    LinearOrientation = LinearLayout.Orientation.Vertical,
                    HorizontalAlignment = HorizontalAlignment.Center
                }
            };

            //Create left description text.
            createText[0] = new TextLabel()
            {
                Text = "Create RadioButton just by properties",
                TextColor = Color.White,
                Size = new Size(window.WindowSize.Width *4 / 10, window.WindowSize.Height / 12),
                Ellipsis = false,
                MultiLine = true,
                LineWrapMode = LineWrapMode.Word,
            };
            left.Add(createText[0]);

            leftbody = new View();
            leftbody.Layout = new GridLayout() { Columns = 4 };
            int num = 4;
            for (int i = 0; i < num; i++)
            {
                group[i] = new RadioButtonGroup();
                modeText[i] = new TextLabel();
                modeText[i].Text = mode[i];
                modeText[i].Size = new Size(window.WindowSize.Width / 8, 48);
                modeText[i].HorizontalAlignment = HorizontalAlignment.Center;
                modeText[i].VerticalAlignment = VerticalAlignment.Center;
                leftbody.Add(modeText[i]);
            }

            for (int i = 0; i < num; i++)
            {
                // create utility radio button.
                utilityRadioButton[i] = new RadioButton();
                var utilityStyle = utilityRadioButton[i].Style;
                utilityStyle.Icon.Opacity = new Selector<float?>
                {
                    Normal = 1.0f,
                    Selected = 1.0f,
                    Disabled = 0.4f,
                    DisabledSelected = 0.4f
                };
                utilityStyle.Icon.BackgroundImage = "";
                utilityStyle.Icon.ResourceUrl = new Selector<string>
                {
                    Normal = ResourcePath + "controller/controller_btn_radio_off.png",
                    Selected = ResourcePath + "controller/controller_btn_radio_on.png",
                    Disabled = ResourcePath + "controller/controller_btn_radio_off.png",
                    DisabledSelected = ResourcePath + "controller/controller_btn_radio_on.png",
                };
                utilityRadioButton[i].ApplyStyle(utilityStyle);
                utilityRadioButton[i].Size = new Size(48, 48);
                utilityRadioButton[i].Margin = new Extents(0, 0, 25, 25);
                utilityRadioButton[i].Icon.Size = new Size(48, 48);

                utilityRadioButton[i].Clicked += OnClicked;
                group[0].Add(utilityRadioButton[i]);

                // create family radio button.
                familyRadioButton[i] = new RadioButton();
                var familyStyle = familyRadioButton[i].Style;
                familyStyle.Icon.Opacity = new Selector<float?>
                {
                    Normal = 1.0f,
                    Selected = 1.0f,
                    Disabled = 0.4f,
                    DisabledSelected = 0.4f
                };
                familyStyle.Icon.BackgroundImage = "";
                familyStyle.Icon.ResourceUrl = new Selector<string>
                {
                    Normal = ResourcePath + "controller/controller_btn_radio_off.png",
                    Selected = ResourcePath + "controller/[Controller] App Primary Color/controller_btn_radio_on_24c447.png",
                    Disabled = ResourcePath + "controller/controller_btn_radio_off.png",
                    DisabledSelected = ResourcePath + "controller/[Controller] App Primary Color/controller_btn_radio_on_24c447.png",
                };
                familyRadioButton[i].ApplyStyle(familyStyle);
                familyRadioButton[i].Size = new Size(48, 48);
                familyRadioButton[i].Text = "familyRadioButton" + i.ToString();
                familyRadioButton[i].Margin = new Extents(0, 0, 25, 25);
                familyRadioButton[i].Icon.Size = new Size(48, 48);

                familyRadioButton[i].Clicked += OnClicked;
                group[1].Add(familyRadioButton[i]);

                // create food radio button.
                foodRadioButton[i] = new RadioButton();
                var foodStyle = foodRadioButton[i].Style;
                foodStyle.Icon.Opacity = new Selector<float?>
                {
                    Normal = 1.0f,
                    Selected = 1.0f,
                    Disabled = 0.4f,
                    DisabledSelected = 0.4f
                };
                foodStyle.Icon.BackgroundImage = "";
                foodStyle.Icon.ResourceUrl = new Selector<string>
                {
                    Normal = ResourcePath + "controller/controller_btn_radio_off.png",
                    Selected = ResourcePath + "controller/[Controller] App Primary Color/controller_btn_radio_on_ec7510.png",
                    Disabled = ResourcePath + "controller/controller_btn_radio_off.png",
                    DisabledSelected = ResourcePath + "controller/[Controller] App Primary Color/controller_btn_radio_on_ec7510.png",
                };
                foodRadioButton[i].ApplyStyle(foodStyle);
                foodRadioButton[i].Size = new Size(48, 48);
                foodRadioButton[i].Margin = new Extents(0, 0, 25, 25);
                foodRadioButton[i].Icon.Size = new Size(48, 48);

                foodRadioButton[i].Clicked += OnClicked;
                group[2].Add(foodRadioButton[i]);

                // create kitchen radio button.
                kitchenRadioButton[i] = new RadioButton();
                var kitchenStyle = kitchenRadioButton[i].Style;
                kitchenStyle.Icon.Opacity = new Selector<float?>
                {
                    Normal = 1.0f,
                    Selected = 1.0f,
                    Disabled = 0.4f,
                    DisabledSelected = 0.4f
                };
                kitchenStyle.Icon.BackgroundImage = "";
                kitchenStyle.Icon.ResourceUrl = new Selector<string>
                {
                    Normal = ResourcePath + "controller/controller_btn_radio_off.png",
                    Selected = ResourcePath + "controller/[Controller] App Primary Color/controller_btn_radio_on_9762d9.png",
                    Disabled = ResourcePath + "controller/controller_btn_radio_off.png",
                    DisabledSelected = ResourcePath + "controller/[Controller] App Primary Color/controller_btn_radio_on_9762d9.png",
                };
                kitchenRadioButton[i].ApplyStyle(kitchenStyle);
                kitchenRadioButton[i].Size = new Size(48, 48);
                kitchenRadioButton[i].Margin = new Extents(0, 0, 25, 25);
                kitchenRadioButton[i].Icon.Size = new Size(48, 48);
                kitchenRadioButton[i].Clicked += OnClicked;
                group[3].Add(kitchenRadioButton[i]);

                leftbody.Add(utilityRadioButton[i]);
                leftbody.Add(familyRadioButton[i]);
                leftbody.Add(foodRadioButton[i]);
                leftbody.Add(kitchenRadioButton[i]);
            }

            ///////////////////////////////////////////////Create by Attributes//////////////////////////////////////////////////////////
            right = new View()
            {
                Size = new Size(window.WindowSize.Width / 2, window.WindowSize.Height * 3 / 4),
                Layout = new LinearLayout()
                {
                    LinearOrientation = LinearLayout.Orientation.Vertical,
                    HorizontalAlignment = HorizontalAlignment.Center
                }
            };

            rightbody = new View();
            rightbody.Layout = new GridLayout() { Columns = 4 };
            createText[1] = new TextLabel() 
            {
                Text = "Create RadioButton just by styles",
                TextColor = Color.White,
                Size = new Size(window.WindowSize.Width * 4 / 10, window.WindowSize.Height / 12),
                Ellipsis = false,
                MultiLine = true,
                LineWrapMode = LineWrapMode.Word,
            };
            right.Add(createText[1]);

            for (int i = 0; i < num; i++)
            {
                group2[i] = new RadioButtonGroup();
                modeText2[i] = new TextLabel();
                modeText2[i].Text = mode[i];
                modeText2[i].Size = new Size(window.WindowSize.Width / 8, 48);
                modeText2[i].HorizontalAlignment = HorizontalAlignment.Center;
                modeText2[i].VerticalAlignment = VerticalAlignment.Center;
                rightbody.Add(modeText2[i]);
            }

            //Create utility style of radio button.
            ButtonStyle utilityStyle2 = new ButtonStyle
            {
                Icon = new ImageViewStyle
                {
                    Size = new Size(48, 48),
                    Opacity = new Selector<float?>
                    {
                        Normal = 1.0f,
                        Selected = 1.0f,
                        Disabled = 0.4f,
                        DisabledSelected = 0.4f
                    },
                    ResourceUrl = new Selector<string>
                    {
                        Normal = ResourcePath + "controller/controller_btn_radio_off.png",
                        Selected = ResourcePath + "controller/controller_btn_radio_on.png",
                        Disabled = ResourcePath + "controller/controller_btn_radio_off.png",
                        DisabledSelected = ResourcePath + "controller/controller_btn_radio_on.png",
                    },
                },
            };
            //Create family style of radio button.
            ButtonStyle familyStyle2 = new ButtonStyle
            {
                Icon = new ImageViewStyle
                {
                    Size = new Size(48, 48),
                    Opacity = new Selector<float?>
                    {
                        Normal = 1.0f,
                        Selected = 1.0f,
                        Disabled = 0.4f,
                        DisabledSelected = 0.4f
                    },
                    ResourceUrl = new Selector<string>
                    {
                        Normal = ResourcePath + "controller/controller_btn_radio_off.png",
                        Selected = ResourcePath + "controller/[Controller] App Primary Color/controller_btn_radio_on_24c447.png",
                        Disabled = ResourcePath + "controller/controller_btn_radio_off.png",
                        DisabledSelected = ResourcePath + "controller/[Controller] App Primary Color/controller_btn_radio_on_24c447.png",
                    },
                },
            };
            //Create food style of radio button.
            ButtonStyle foodStyle2 = new ButtonStyle
            {
                Icon = new ImageViewStyle
                {
                    Size = new Size(48, 48),
                    Opacity = new Selector<float?>
                    {
                        Normal = 1.0f,
                        Selected = 1.0f,
                        Disabled = 0.4f,
                        DisabledSelected = 0.4f
                    },
                    ResourceUrl = new Selector<string>
                    {
                        Normal = ResourcePath + "controller/controller_btn_radio_off.png",
                        Selected = ResourcePath + "controller/[Controller] App Primary Color/controller_btn_radio_on_ec7510.png",
                        Disabled = ResourcePath + "controller/controller_btn_radio_off.png",
                        DisabledSelected = ResourcePath + "controller/[Controller] App Primary Color/controller_btn_radio_on_ec7510.png",
                    },
                },
            };
            //Create kitchen style of radio button.
            ButtonStyle kitchenStyle2 = new ButtonStyle
            {
                Icon = new ImageViewStyle
                {
                    Size = new Size(48, 48),
                    Opacity = new Selector<float?>
                    {
                        Normal = 1.0f,
                        Selected = 1.0f,
                        Disabled = 0.4f,
                        DisabledSelected = 0.4f
                    },
                    ResourceUrl = new Selector<string>
                    {
                        Normal = ResourcePath + "controller/controller_btn_radio_off.png",
                        Selected = ResourcePath + "controller/[Controller] App Primary Color/controller_btn_radio_on_9762d9.png",
                        Disabled = ResourcePath + "controller/controller_btn_radio_off.png",
                        DisabledSelected = ResourcePath + "controller/[Controller] App Primary Color/controller_btn_radio_on_9762d9.png",
                    },
                },
            };
            for (int i = 0; i < num; i++)
            {
                utilityRadioButton2[i] = new RadioButton(utilityStyle2);
                utilityRadioButton2[i].Size = new Size(48, 48);
                utilityRadioButton2[i].Margin = new Extents(0, 0, 25, 25);
                utilityRadioButton2[i].Clicked += OnClicked;
                group2[0].Add(utilityRadioButton2[i]);

                familyRadioButton2[i] = new RadioButton(familyStyle2);
                familyRadioButton2[i].Size = new Size(48, 48);
                familyRadioButton2[i].Margin = new Extents(0, 0, 25, 25);
                familyRadioButton2[i].Clicked += OnClicked;
                group2[1].Add(familyRadioButton2[i]);

                foodRadioButton2[i] = new RadioButton(foodStyle2);
                foodRadioButton2[i].Size = new Size(48, 48);
                foodRadioButton2[i].Margin = new Extents(0, 0, 25, 25);
                foodRadioButton2[i].Clicked += OnClicked;
                group2[2].Add(foodRadioButton2[i]);

                kitchenRadioButton2[i] = new RadioButton(kitchenStyle2);
                kitchenRadioButton2[i].Size = new Size(48, 48);
                kitchenRadioButton2[i].Margin = new Extents(0, 0, 25, 25);
                kitchenRadioButton2[i].Clicked += OnClicked;
                group2[3].Add(kitchenRadioButton2[i]);

                rightbody.Add(utilityRadioButton2[i]);
                rightbody.Add(familyRadioButton2[i]);
                rightbody.Add(foodRadioButton2[i]);
                rightbody.Add(kitchenRadioButton2[i]);
            }

            root.Add(left);
            root.Add(right);
            left.Add(leftbody);

            groupInfo = new TextLabel()
            {
                Text = "HashCode of ItemGroup : ",
                Margin = new Extents(25, 0, 25, 25),
                Ellipsis = false,
                MultiLine = true,
                LineWrapMode = LineWrapMode.Mixed,
            };
            groupInfo.HorizontalAlignment = HorizontalAlignment.Begin;
            left.Add(groupInfo);

            right.Add(rightbody);

            utilityRadioButton[2].IsEnabled = false;
            familyRadioButton[2].IsEnabled = false;
            foodRadioButton[2].IsEnabled = false;
            kitchenRadioButton[2].IsEnabled = false;

            utilityRadioButton2[2].IsEnabled = false;
            familyRadioButton2[2].IsEnabled = false;
            foodRadioButton2[2].IsEnabled = false;
            kitchenRadioButton2[2].IsEnabled = false;

            utilityRadioButton[3].IsEnabled = false;
            familyRadioButton[3].IsEnabled = false;
            foodRadioButton[3].IsEnabled = false;
            kitchenRadioButton[3].IsEnabled = false;
            utilityRadioButton[3].IsSelected = true;
            familyRadioButton[3].IsSelected = true;
            foodRadioButton[3].IsSelected = true;
            kitchenRadioButton[3].IsSelected = true;

            utilityRadioButton2[3].IsEnabled = false;
            familyRadioButton2[3].IsEnabled = false;
            foodRadioButton2[3].IsEnabled = false;
            kitchenRadioButton2[3].IsEnabled = false;
            utilityRadioButton2[3].IsSelected = true;
            familyRadioButton2[3].IsSelected = true;
            foodRadioButton2[3].IsSelected = true;
            kitchenRadioButton2[3].IsSelected = true;

            Content = root;
        }

        private void OnClicked(object sender, ClickedEventArgs e)
        {
            RadioButton rbtn = sender as RadioButton;
            groupInfo.Text = "HashCode of ItemGroup : " + rbtn.ItemGroup.GetHashCode().ToString();
        }

        protected override void Dispose(DisposeTypes type)
        {
            if (Disposed)
            {
                return;
            }

            if (type == DisposeTypes.Explicit)
            {
                Deactivate();
            }

            base.Dispose(type);
        }

        private void Deactivate()
        {
            if (root != null)
            {
                int num = 4;
                for (int i = 0; i < num; i++)
                {
                    leftbody.Remove(utilityRadioButton[i]);
                    utilityRadioButton[i].Dispose();
                    utilityRadioButton[i] = null;

                    leftbody.Remove(familyRadioButton[i]);
                    familyRadioButton[i].Dispose();
                    familyRadioButton[i] = null;

                    leftbody.Remove(foodRadioButton[i]);
                    foodRadioButton[i].Dispose();
                    foodRadioButton[i] = null;

                    leftbody.Remove(kitchenRadioButton[i]);
                    kitchenRadioButton[i].Dispose();
                    kitchenRadioButton[i] = null;

                    leftbody.Remove(modeText[i]);
                    modeText[i].Dispose();
                    modeText[i] = null;

                    rightbody.Remove(utilityRadioButton2[i]);
                    utilityRadioButton2[i].Dispose();
                    utilityRadioButton2[i] = null;

                    rightbody.Remove(familyRadioButton2[i]);
                    familyRadioButton2[i].Dispose();
                    familyRadioButton2[i] = null;

                    rightbody.Remove(foodRadioButton2[i]);
                    foodRadioButton2[i].Dispose();
                    foodRadioButton2[i] = null;

                    rightbody.Remove(kitchenRadioButton2[i]);
                    kitchenRadioButton2[i].Dispose();
                    kitchenRadioButton2[i] = null;

                    rightbody.Remove(modeText2[i]);
                    modeText2[i].Dispose();
                    modeText2[i] = null;
                }

                left.Remove(createText[0]);
                createText[0].Dispose();
                createText[0] = null;
                left.Remove(leftbody);
                leftbody.Dispose();
                leftbody = null;
                right.Remove(createText[1]);
                createText[1].Dispose();
                createText[1] = null;
                right.Remove(rightbody);
                rightbody.Dispose();
                rightbody = null;

                root.Remove(left);
                left.Dispose();
                left = null;
                root.Remove(right);
                right.Dispose();
                right = null;
                NUIApplication.GetDefaultWindow().Remove(root);
                root.Dispose();
                root = null;
            }
        }
    }

    class RadioButtonTest1: IExample
    {
        private Window window;

        public void Activate()
        {
#pragma warning disable Reflection // The code contains reflection
            Log.Info(this.GetType().Name, $"@@@ this.GetType().Name={this.GetType().Name}, Activate()");
#pragma warning restore Reflection // The code contains reflection

            window = NUIApplication.GetDefaultWindow();
            window.GetDefaultNavigator().Push(new RadioButtonTestPage1(window));
        }

        public void Deactivate()
        {
#pragma warning disable Reflection // The code contains reflection
            Log.Info(this.GetType().Name, $"@@@ this.GetType().Name={this.GetType().Name}, Deactivate()");
#pragma warning restore Reflection // The code contains reflection
            window.GetDefaultNavigator().Pop();
        }
    }
}

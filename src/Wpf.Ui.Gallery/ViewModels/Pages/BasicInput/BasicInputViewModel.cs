﻿// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using System.Collections.ObjectModel;
using Wpf.Ui.Gallery.Models;

namespace Wpf.Ui.Gallery.ViewModels.Pages.BasicInput;

public partial class BasicInputViewModel : ObservableObject
{
    [ObservableProperty]
    private ICollection<NavigationCard> _navigationCards = new ObservableCollection<NavigationCard>
        {
            new()
            {
                Name = "Anchor",
                Icon = SymbolRegular.CubeLink20,
                Description = "Button which opens a link.",
                Link = "Anchor"
            },
            new()
            {
                Name = "Button",
                Icon = SymbolRegular.ControlButton24,
                Description = "Simple button.",
                Link = "Button"
            },
            new()
            {
                Name = "Hyperlink",
                Icon = SymbolRegular.Link24,
                Description = "Opens a link.",
                Link = "Hyperlink"
            },
            new()
            {
                Name = "ToggleButton",
                Icon = SymbolRegular.ToggleRight24,
                Description = "Toggleable button.",
                Link = "ToggleButton"
            },
            new()
            {
                Name = "ToggleSwitch",
                Icon = SymbolRegular.ToggleLeft24,
                Description = "Switchable button with a ball.",
                Link = "ToggleSwitch"
            },
            new()
            {
                Name = "CheckBox",
                Icon = SymbolRegular.CheckmarkSquare24,
                Description = "Button with binary choice.",
                Link = "CheckBox"
            },
            new()
            {
                Name = "ComboBox",
                Icon = SymbolRegular.Filter16,
                Description = "Button with binary choice.",
                Link = "ComboBox"
            },
            new()
            {
                Name = "RadioButton",
                Icon = SymbolRegular.RadioButton24,
                Description = "Set of options as buttons.",
                Link = "RadioButton"
            },
            new()
            {
                Name = "RatingControl",
                Icon = SymbolRegular.Star24,
                Description = "Rating using stars.",
                Link = "Rating"
            },
            new()
            {
                Name = "ThumbRate",
                Icon = SymbolRegular.ThumbLike24,
                Description = "Like or dislike.",
                Link = "ThumbRate"
            },
            new()
            {
                Name = "Slider",
                Icon = SymbolRegular.HandDraw24,
                Description = "Sliding control.",
                Link = "Slider"
            }
        };
}

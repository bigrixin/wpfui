﻿using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Wpf.Ui.Gallery.Controls;

[ContentProperty(nameof(ExampleContent))]
public class ControlExample : Control
{
    public static readonly DependencyProperty ExampleContentProperty =
        DependencyProperty.Register(nameof(ExampleContent),
            typeof(object), typeof(ControlExample), new PropertyMetadata(null));

    public static readonly DependencyProperty XamlCodeProperty =
        DependencyProperty.Register(nameof(XamlCode),
            typeof(string), typeof(ControlExample), new PropertyMetadata(null));

    public static readonly DependencyProperty XamlCodeSourceProperty =
        DependencyProperty.Register(nameof(XamlCodeSource),
            typeof(Uri), typeof(ControlExample),
            new PropertyMetadata(null,
                static (o, args) => ((ControlExample)o).OnXamlCodeSourceChanged((Uri)args.NewValue)));

    public static readonly DependencyProperty CsharpCodeProperty =
        DependencyProperty.Register(nameof(CsharpCode),
            typeof(string), typeof(ControlExample), new PropertyMetadata(null));

    public static readonly DependencyProperty CsharpCodeSourceProperty =
        DependencyProperty.Register(nameof(CsharpCodeSource),
            typeof(Uri), typeof(ControlExample),
            new PropertyMetadata(null,
                static (o, args) => ((ControlExample)o).OnCsharpCodeSourceChanged((Uri)args.NewValue)));

    public object? ExampleContent
    {
        get => GetValue(ExampleContentProperty);
        set => SetValue(ExampleContentProperty, value);
    }

    public string? XamlCode
    {
        get => (string)GetValue(XamlCodeProperty);
        set => SetValue(XamlCodeProperty, value);
    }

    public Uri? XamlCodeSource
    {
        get => (Uri)GetValue(XamlCodeSourceProperty);
        set => SetValue(XamlCodeSourceProperty, value);
    }

    public string? CsharpCode
    {
        get => (string)GetValue(CsharpCodeProperty);
        set => SetValue(CsharpCodeProperty, value);
    }

    public Uri? CsharpCodeSource
    {
        get => (Uri)GetValue(CsharpCodeSourceProperty);
        set => SetValue(CsharpCodeSourceProperty, value);
    }

    private void OnXamlCodeSourceChanged(Uri uri)
    {
        XamlCode = LoadResource(uri);
    }

    private void OnCsharpCodeSourceChanged(Uri uri)
    {
        CsharpCode = LoadResource(uri);
    }

    private static string LoadResource(Uri uri)
    {
        try
        {
            if (Application.GetResourceStream(uri) is not { } steamInfo)
                return string.Empty;

            using StreamReader streamReader = new(steamInfo.Stream, Encoding.UTF8);
            return streamReader.ReadToEnd();

        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            return e.ToString();
        }
    }
}

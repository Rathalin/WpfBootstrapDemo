# WPF Bootstrap Demo
A demo to demonstrate the usage of the Bootstrap imitation stylesheet.

## Setup

### Download 

To use the Bootstrap-like styles download [BootstrapImitation.xaml](https://github.com/Rhatalin/WpfBootstrapDemo/blob/master/BootstrapDemo/BootstrapImitation.xaml).

### Integration

Add **BootstrapImitation.xaml** to your WPF project and go to **App.xaml**. The code below shows how you can integrate the stylesheet into your Resource Dictionary:

```csharp
<Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="BootstrapImitation.xaml"></ResourceDictionary>
            </ResourceDictionary.MergedDictionaries>
            
        </ResourceDictionary>
    </Application.Resources>
```

## Current Features

For now i've added buttons, outline buttons and alerts.

### Buttons

![buttons](https://github.com/Rhatalin/WpfBootstrapDemo/blob/master/BootstrapDemo/Images/Demo_Buttons.PNG)

### Outline Buttons

![outlinebuttons](https://github.com/Rhatalin/WpfBootstrapDemo/blob/master/BootstrapDemo/Images/Demo_OutlineButtons.PNG)

### Alerts

![alerts](https://github.com/Rhatalin/WpfBootstrapDemo/blob/master/BootstrapDemo/Images/Demo_Alerts.PNG)

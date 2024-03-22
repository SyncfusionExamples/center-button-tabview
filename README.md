# Xamarin Tabbed View (SfTabView) 

The Tabbed View control is available in Xamarin.Forms, Xamarin.Android, Xamarin.iOS and Xamarin.UWP. It helps you to create the customizable features that are used to explore and switch among the different views. 

For know more details about TabView: https://www.syncfusion.com/xamarin-ui-controls/xamarin-tabbed-view

TabView user guide documentation: https://help.syncfusion.com/xamarin/tabbed-view/getting-started
## Creating the project
Create a new BlankApp (Xamarin.Forms.Portable) application in Xamarin Studio or Visual Studio for Xamarin.Forms.

### Adding SfTabView in Xamarin.Forms
Add the required assembly references to the PCL and renderer projects as discussed in the Assembly deployment section.

Import the control namespace as shown in the following code.

**[XAML]**
```
xmlns:tabView="clr-namespace:Syncfusion.XForms.TabView;assembly=Syncfusion.SfTabView.XForms"
```
**[C#]**
```
using Syncfusion.XForms.TabView;
```
Set the control to content in ContentPage.

**[XAML]**
```
 <ContentPage.Content> 
        <tabView:SfTabView/> 
 </ContentPage.Content> 
```
**[C#]**
```
public MainPage()   
{   
    InitializeComponent();       
    tabView = new SfTabView();   
    this.Content = tabView;  
}  
```
## CenterButton Customization in Xamarin Tabbed View (SfTabView)
To enable CenterButton, set the OverFlowMode of Xamarin.Forms SfTabView to CenterButton.

**[XAML]**
```
<tabView:SfTabView OverflowMode="CenterButton"
                   x:Name="tabView">
</tabView:SfTabView>
```
## Customize CenterButtonSettings
We can customize the CenterButton using the properties of CenterButtonSetting. The following properties are used to customize the view of CenterButton BackgroundColor, BorderColor, BorderThickness, Height, Title, TitleFontAttributes, TitleFontColor, TitleFontSize, Width.
**[XAML]**
```
<tabView:SfTabView.CenterButtonSettings>
    <tabView:CenterButtonSettings Height="80" Width="100"
                                  Title="Center Button" TitleFontColor="Green"
                                  TitleFontAttributes="Bold">
    </tabView:CenterButtonSettings>
</tabView:SfTabView.CenterButtonSettings>
```
## CenterButtonTapped event
When CenterButton is tapped, the CenterButtonTapped event occurs. Using this event we can set alert message.

**[XAML]**
```
<tabView:SfTabView CenterButtonTapped="TabView_CenterButtonTapped">
</tabView:SfTabView>
```
## Custom CenterButton
When built-in view is not needed, it can be overridden by adding custom views to the CenterButtonView. The CenterButton view can be customized by adding images, labels, buttons inside the CenterButtonView. Refer the following code sample to know about customizing the view of CenterButton.

**[XAML]**
```
<tabView:SfTabView.CenterButtonView>
    <Grid>
        <Image Source="Compose.png"
               Aspect="AspectFill"
               VerticalOptions="CenterAndExpand"
               HorizontalOptions="CenterAndExpand">
            <Image.GestureRecognizers>
                <TapGestureRecognizer Tapped="TapGestureRecognizer_Tapped" />
            </Image.GestureRecognizers>
        </Image>
    </Grid>
</tabView:SfTabView.CenterButtonView>
```
## How to run this application?

To run this application, you need to first clone the center-button-tabview repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
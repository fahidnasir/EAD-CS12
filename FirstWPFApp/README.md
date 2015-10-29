# WPF (previously known as "Avalon")

WPF use eXtensible Application Markup Language (XAML; /ˈzæməl/), which is based on XML to desing interfaces.

XAML is design to meet the modern design needs (Animation, 2D/3D Graphics, Images/Videos Streaming, Data-Binding etc.)

WPF Application contains mainly these components to work.
##### 1. [App.Xaml] (http://www.wpf-tutorial.com/wpf-application/working-with-app-xaml/)
##### 2. [App.config] (https://msdn.microsoft.com/en-us/library/1xtk877y.aspx)
##### 3. **View** and its **Code-Behind** file (Both are **Same** class **with partial** functionality)
##### 4. **ViewModel** which contains the data and validation about the **View** (Also works as Controller in MVC)
##### 5. **Model** it is the Database Table Representation **Refelect** the data from **Database**



# Binding
#### 1. Element to Element Binding

```
<TextBox  x:Name="txtEmail"
          Width="{Binding ElementName=txtPassword, Path=Width, Mode=TwoWay, FallbackValue=200}" />
```

Other element which is bound to *txtEmail*

```
<PasswordBox  x:Name="txtPassword"
              Width="{Binding ElementName=txtEmail, Path=Width, Mode=TwoWay, FallbackValue=200}" />
```

##### Explanation
- value **ElementName** property is which control you want to bind
- value of **Path** is the Property of the above Element you want to bind with
- value of **Mode** is the way you want the bind work (**Mode** valid values [OneTime, OneWay, OneWayToSource, TwoWay])
- value of **FallbackValue** is the value which you want to set for the first time if Source value is empty

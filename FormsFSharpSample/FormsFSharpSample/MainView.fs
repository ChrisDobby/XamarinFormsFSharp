namespace FormsFSharpSample

open Xamarin.Forms

type MainView() = 
    inherit ContentPage()
    do base.Content <- Label(Text = "FormsFSharpSample",
                             HorizontalOptions = LayoutOptions.Center,
                             VerticalOptions = LayoutOptions.Center,
                             FontSize = 24.0,
                             TextColor = Color.Pink,
                             FontAttributes = FontAttributes.Italic,
                             Rotation = -15.0)

type App() = 
    inherit Application(MainPage = MainView())

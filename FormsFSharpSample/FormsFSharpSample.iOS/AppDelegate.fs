namespace FormsFSharpSample.iOS

open System
open UIKit
open Foundation

open FormsFSharpSample

[<Register ("AppDelegate")>]
type AppDelegate () =
    inherit Xamarin.Forms.Platform.iOS.FormsApplicationDelegate ()

    let window = new UIWindow (UIScreen.MainScreen.Bounds)

    // This method is invoked when the application is ready to run.
    override this.FinishedLaunching (app, options) =

        Xamarin.Forms.Forms.Init()
        this.LoadApplication(App())
        base.FinishedLaunching (app, options)
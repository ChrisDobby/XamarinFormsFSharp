namespace FormsFSharpSample.Droid

open System

open Android.App
open Android.Content
open Android.Content.PM
open Android.OS
open Android.Runtime
open Android.Views
open Android.Widget

open Xamarin.Forms.Platform.Android

open FormsFSharpSample

//[<Activity (Label = "FormsFSharpSample.Droid", , Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)>]
[<Activity (Label = "FormsFSharpSample.Droid", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize)>]
type MainActivity () =
    inherit FormsAppCompatActivity ()

    let mutable count:int = 1

    override this.OnCreate (bundle) =

        FormsAppCompatActivity.TabLayoutResource <- Resource_Layout.Tabbar
        FormsAppCompatActivity.ToolbarResource <- Resource_Layout.Toolbar

        base.OnCreate (bundle)

        Xamarin.Forms.Forms.Init(this, bundle)

        this.LoadApplication(App())


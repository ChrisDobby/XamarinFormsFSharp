namespace FormsFSharpSample

open GalaSoft.MvvmLight
open GalaSoft.MvvmLight.Command

type MainViewModel() =
    inherit ViewModelBase()

    let mutable internalCounter = 0;
    
    let add1 x = x + 1

    member this.SampleText = "Hello from FormsFSharpSample.MainViewModel"
    member this.CountText = sprintf "Clicked %d times" internalCounter
    member this.Count 
        with get () = internalCounter
        and set (value) = 
            internalCounter <- value
            this.RaisePropertyChanged("CountText")

    member this.Increment = RelayCommand(fun () -> this.Count <- add1 this.Count)
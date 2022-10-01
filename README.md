#CRM MAUI

Study on going
 </br>

//Routing with Back button </br>
  App.xaml.cs </br>
  Routing.RegisterRoute(nameof(HomePage), typeof(HomePage)); </br>

 => will navigate as  </br>
  await Shell.Current.GoToAsync($"{nameof(HomePage)}");
  
  
//Routing without Back button </br>

AppShell.xaml
  <ShellContent
        Title="HomePage"
        ContentTemplate="{DataTemplate viewp:HomePage}"
        Route="HomePage" />
         </br>
=> will navigate as
 await Shell.Current.GoToAsync($"//{nameof(HomePage)}");


Command Binding>>
 public ICommand LogOutCommand { private set; get; }
        public AppShellViewModel()
        {
            LogOutCommand = new Command(
             execute: () =>
             {
                 SignOut();
             });
        }
        async void SignOut()
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }

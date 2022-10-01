#CRM MAUI

Study on going


//Routing with Back button
  App.xaml.cs
  Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));

 => will navigate as 
  await Shell.Current.GoToAsync($"{nameof(HomePage)}");
  
  
//Routing without Back button
AppShell.xaml
  <ShellContent
        Title="HomePage"
        ContentTemplate="{DataTemplate viewp:HomePage}"
        Route="HomePage" />
=> will navigate as
 await Shell.Current.GoToAsync($"//{nameof(HomePage)}");

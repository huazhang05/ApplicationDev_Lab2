   M S B A M L   `   `   `  ????J  FWPF_BankCharges, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WPF_BankChargesWPF_BankCharges  5   	        WPF_BankCharges.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WPF_BankCharges     5   	     ? Title$  Bank Charges??5   	   $	??450??6   $	??800??6+   .??5	      ? -   5         ?Name$ balance??5	       ? ColumnDefinitions 5
   
   ?? 5      ?? 5      $	??19* ?6   .+?5   
   ?? $??Bank Charges??6   $
??Left=?6'   $??
281,28,0,0q?6B   $	??Top=?6V   $??18(?6n   $
??Bold"?6|   $??Arial Black)?6?   $??1??6?   ?? 5   
   $??1??6   $??Account Balance:??6    $
??Left=?6;   $??
213,96,0,0q?6V   $	??Top=?6j   $??14(?6?   ?? 5   
   -   5         ??Name$ accountBalanceInput??5      $??1??6/   $
??Left=?6?   $??355,100,0,0q?6Z    ?? TextWrapping$
 Wrap=?6o   $	??Top=?6?   $	??120??6?   $??14(?6?   ?? 5   
   $??1??6   $??Checks Numbers:??6    $
??Left=?6:   $??213,139,0,0q?6U   $	??Top=?6j   $??14(?6?   ?? 5   
   -   5        $ checksNumbersInput??5      $??1??6.   $
??Left=?6>   $??355,143,0,0q?6Y   $
 Wrap=?6n   $	??Top=?6?   $	??120??6?   $??14(?6?   ?? 5   
   $??1??6   $??Monthly Service Fee:??6    $
??Left=?6?   $??191,254,0,0q?6Z   $	??Top=?6o   $??14(?6?   $
??Bold"?6?   ?? 5   
   -   5        $ 
serviceFee??5      $??1??6&   $
??Left=?66   $??360,258,0,0q?6Q   $
 Wrap=?6f   $	??Top=?6z   $	??120??6?   $??14(?6?   ?? 5   
   -   5        $??1??5      $??	Calculate??6!   $
??Left=?65   $??320,217,0,0q?6P   $	??Top=?6e   $??14(?6}   6?   5      5      
   M S B A M L   `   `   `  ????M  IWPF_ShippingCharge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF_ShippingChargeWPF_ShippingCharge  5   	   #    WPF_ShippingCharge.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WPF_ShippingCharge     5   	     ? Title$  Shipping Charges??5   	   $	??450??6"   $	??800??6/   .??5	      ? .+?5
   
   ?? $??Shipping Charges??6   $??Center=?6+   $??0,28,0,0q?6H   $	??Top=?6Z   $??18(?6r   $
??Bold"?6?   $??Arial Black)?6?   ?? 5   
   $??Weight??6   $
??Left=?6!   $??
295,96,0,0q?6<   $	??Top=?6P   $??14(?6h   ?? 5   
   -   5         ??Name$ weightInput??5      $
??Left=?6'   $??374,100,0,0q?6B    ?? TextWrapping$
 Wrap=?6W   $	??Top=?6k   $	??120??6?   $??14(?6?   ?? 5   
   $	??kg.??6   $
??Left=?6   $??
499,96,0,0q?69   $	??Top=?6M   $??14(?6e   ?? 5   
   $??Distance??6   $
??Left=?6#   $??286,130,0,0q?6>   $	??Top=?6S   $??14(?6k   ?? 5   
   -   5        $ distanceInput??5      $
??Left=?6)   $??374,134,0,0q?6D   $
 Wrap=?6Y   $	??Top=?6m   $	??120??6?   $??14(?6?   ?? 5   
   $??miles??6   $
??Left=?6    $??499,130,0,0q?6;   $	??Top=?6P   $??14(?6h   ?? 5   
   $??Shipping Charge??6   $
??Left=?6*   $??237,236,0,0q?6E   $	??Top=?6Z   $??14(?6r   ?? 5   
   -   5        $ shippingChargeReslt??5      $
??Left=?6/   $??375,240,0,0q?6J   $
 Wrap=?6_   $	??Top=?6s   $	??120??6?   $??14(?6?   ?? 5   
   $??$??6   $
??Left=?6   $??500,236,0,0q?67   $	??Top=?6L   $??14(?6d   ?? 5   
   -   5        $??	Calculate??5      $??Center=?6%   $	??Top=?6B   $??14(?6Z   $??	0,191,0,0q?6h   6{   5      5      
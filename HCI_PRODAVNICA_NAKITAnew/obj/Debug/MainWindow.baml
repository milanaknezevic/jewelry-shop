   M S B A M L   `   `   `  ����S  OHCI_PRODAVNICA_NAKITAnew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HCI_PRODAVNICA_NAKITAnewHCI_PRODAVNICA_NAKITAnew  5      )    #HCI_PRODAVNICA_NAKITAnew.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:HCI_PRODAVNICA_NAKITAnew     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65    � WindowStyle$
 None=�6Z    � 
ResizeMode$ NoResize=�6m   .��5      � ��5   
   �� 5       �� 
StartPoint$ 0.1,0&�6"    �� EndPoint$ 0.9,1&�65   .��5      �    dashboardStartColor � Color# �   6    � Offset$ 1Q�6M   � 5        dashboardEndColor# �  6   $ 0Q�6K   5      .+�5   
   �� $	��415��6   $	��Top=�6    �� CornerRadius$ 0 0 180 180��66   ���	#FFF9F9F35      �� 5   
   	 �� Orientation$	 
Horizontal=�6   .+�5      �� $	��320��6   $��20,52,20.4,74.6q�6%   .+�5      �� $��mainWindow2.jpg��6   $	��300��61   $	��284��6=   $	��Top=�6J   $��10,0,10,220q�6b   $
��Fill=�6w   5      �� 5      $	��350��6   .+�5      �� $��20,40,20.4,40q�6   $	��302��64   .+�5       ��   	textBlock#���  6    $��10,20,10.4,20q�6D    
 Header#���  6[   
 �� TextAlignment$
 Center=�6�   $��38(�6�   $��Great Vibes)�6�   $��50��6�   6�   �� 5!      $	 
Horizontal=�6!   $��10q�6:   .+�5"      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�62   $��25��6>   $��25��6I     
fontColor1#���  6U   �� 5#      -   5         ��Name$ txtUsername��5#   "   $
��10 0q�67     unesiUsername)  #MaterialDesignThemes.Wpf.HintAssist   Hint# �  6E   #���  6�     	fontColor#���  6�   $	��250��6�   
������� �� 
CaretBrush �	#FFD94448 �� SelectionBrush �	#FFD94448$��15(�6-  $��
Sitka Text)�6;  $
��Bold"�6S  $��43��6e  6q  5$      �� 5%      $	 
Horizontal=�6!   $��10q�6:   .+�5&        $
 Lock=�62   $��25��6>   $��25��6I   #���  6U   G� 5'      -   5         G�Name$ txtPassword��5'   &   $
��10 0q�6;   $ ********��6I   #���  6s   #���  6�   $	��250��6�   
������� G� 
CaretBrush �	#FFD94448 G� SelectionBrush �	#FFD94448$��15(�6  $��
Sitka Text)�6'  $
��Bold"�6?  $��44��6Q  6]  5)      �� 5+      $��10q�6!   $��Center=�6-   .+�5,      �� -   5         ��Name$ btnLogin��5.   ~   $	��117��5,   !   $��50��6-     MaterialDesignRaisedButton#��[ 69   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5-      $��2q�6H     darkSeaGreen#���  6\   #���  5.      #���  6D    � ToolTip$ Login��6n    	 loginButton#��� 	 6�   5/      50      51      52      �� 54      $	��100��6   .+�55      �� -   5        $ btnExit��56      $��22,20q�55       &
 "MaterialDesignFloatingActionButton#��[
 6)   #���  6e   $��57��56   ;   .��57        $ Close=�6.   #���  6<   #���  6j   $��30��6�   $��30��6�   58      59      5:      5<      5=      
   M S B A M L   `   `   `  ����S  OHCI_PRODAVNICA_NAKITAnew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HCI_PRODAVNICA_NAKITAnewHCI_PRODAVNICA_NAKITAnew  5   	   +    %HCI_PRODAVNICA_NAKITAnew.ProfilWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:HCI_PRODAVNICA_NAKITAnew     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Working��5      $	��500��6   $	��800��6"    � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�6(    � 
ResizeMode$ NoResize=�5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��97* �6    � RowDefinitions 5   
   �� 5      $
��541* �6   .+�5   
   � $��2��6   $��2��6#   ��5      �� 5       �� 
StartPoint$ 0.1,0&�6&    �� EndPoint$ 0.9,1&�69   .��5      �    
startColor � Color# �   6#   	 � Offset$	 1Q�6H   � 5        endColor# �  6#   $	 0Q�6F   5      .+�5!      �� -   5        
 ��Name$
 border��5!   "   $	��443��6   $	��Top=�62    �� CornerRadius$ 	0 0 180 0��6J     
background#���  6c   ._�5&      �� -   5         ��Name$ datagridIbuuton��5&       �� Orientation$ 
Horizontal=�66   $��203,0,0,23.2q�6O   .+�5'      &   System.Windows.Controls.DataGrid  -   5          Name$ grid1��5'   q      AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6;      
IsReadOnly . $y�Hidden=�6]      CanUserDeleteRows . $
��Left=�6�   $	��351��6�   $��	60,49,0,0q�6�   $	��Top=�6�   $	��429��6�     buttonBackground#���  6"     Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)        headerNayiv,  &System.Windows.Controls.DataGridColumn   Header# �  61      Width$
 Auto 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6e   �� *naziv+  5*        headerCijena# �  61   $
 Auto 6Y    6f   �� *cijena+  5+        headerGramaza# �  61   $
 Auto 6Z    6g   �� *	gramaza+5.      �� 5/      �� 50      $ 
Horizontal=�6!   $��20q�6:   $��83��6G   .+�51      �� -   5         ��Name$ ZatvoriButton��51   !   $y�Hidden=�68     zatvori#���  6L   $
��Auto��6p   $��0,109,0,226q�6~     	fontColor#���  6�   #���  6�   $��83��6  52      53      56      57      � 58   
   $��1��6   $��1��6   $y�Visible=�6,   .+�59      �� -   5        $ itemList��59      5;      5<      � 5=   
   $y�Visible=�6   ��5?      �� 5@      $ 0.5,1&�6&   $ 0.5,0&�67   .��5A      �  	 dashboardStartColor# � 	 6#   $	 1Q�6Q   � 5B       
 dashboardEndColor# � 
 6#   $	 0Q�6O   5C       5E      �� 5F      $	��100 �6    �� 5G      $��5* �6    �� 5H      $��45 �6     J� Effect 5J      3  -System.Windows.Media.Effects.DropShadowEffect  5K         Color$ 	#FFD6CFCF��6#      RenderingBias$ Quality=�65      ShadowDepth$ 1Q�6M   .+�5M      � ��5N      �� 5O      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5P      � $ White��6'   $	 1Q�65   � 5Q      $ White��6'   $	 0Q�65   5R      .+�5T      �� $��userrrrr.png��6   $	��Top=�6.   5U      ]� 5V      $��1��6   $��
0,0,0,50.2q�6%   .+�5W      �� $ Vertical=�6   $��
0,0,0,10.2q�64   .+�5X      �� -   5        $ Nakit��5X   )   $��10q�6   #���  68   #���  6a    	 nakit#���  6�   �� 5Y      -   5        $ Kupovine��5Y   1   $��
10 5 10 10q�6   #���  6C   #���  6l     mojeKupovine#���  6�   �� 5Z      -   5        $ 	MojProfil��5Z   1   $��
10 5 10 10q�6   #���  6D   #���  6m   .��5_      � $	��150��6   .+�5a      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�66   �� 5b      -	   5         ��Name$ 	mojprofil��5b   (   $��Center=�6;    
 profil#���  6X   5f      5g      5l      5m      �� 5n      -
   5        $ LogoutButton��5n      #���  6G   #���  6p   $
��Auto��6�   $��1��6�   $��	0,344,0,0q�6�   $��2��6�   .��5o      � $	��150��6    5p      �� 5q      $	��59* �6+   �� 5r      $	��13* �6+   �� 5s      $��3* �6+   .+�5u        $ Logout=�6.   �� 5v      -   5        $ logoutTextBlock��5v       $��Center=�69     odjaviSeButton#���  6V   $��35,0,4,-0.4q�6~   $��2��6�   $	��105��6�   5w      5x      5y      5}      5~      
   M S B A M L   `   `   `  ����S  OHCI_PRODAVNICA_NAKITAnew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HCI_PRODAVNICA_NAKITAnewHCI_PRODAVNICA_NAKITAnew  5      ,    &HCI_PRODAVNICA_NAKITAnew.WorkingWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:HCI_PRODAVNICA_NAKITAnew     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
     � Title$  Working��5   	   $	��500��6   $	��800��6&    � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�6*    � 
ResizeMode$ NoResize=�5      .��5      � $	��500��6   $	��800��6   $	��Top=�6$    � RowDefinitions 5   
   �� 5      $	��27* �6   �� 5      $	��73* �6   ��5   
   �� 5       �� 
StartPoint$ 0.1,0&�6"    �� EndPoint$ 0.9,1&�65   .��5      �    
startColor � Color# �   6    � Offset$ 1Q�6D   � 5        endColor# �  6   $ 0Q�6B   5      .+�5    
   �� $	��450��6   $	��Top=�6   	 �� CornerRadius$	 0 0 180 180��67   
�������$��0,0,10,0q�6j   $��2��6|   &   System.Windows.Controls.DataGrid  5"   
   -   5        
  Name$
 grid1��5"   Q      AutoGenerateColumns .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6A      CanUserDeleteRows . $
��Left=�6y   $	��264��6�   $��249,112,0,0q�6�   $	��Top=�6�   $	��503��6�     	fontColor#���  6    buttonBackground#���  6-  $��2��6]     Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$        headerNayiv,  &System.Windows.Controls.DataGridColumn   Header# �  6%      Width$
 Auto 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Y   �� *naziv+  5%        headerCijena# �  6%   $
 Auto 6M    6Z   �� *cijena+  5&        headerGramaza# �  6%   $
 Auto 6N    6[   �� *	gramaza+  5'        headerKolicina# �  6%   $
 Auto 6O    6\   �� *
kolicina+5*      � 5-   
   $��
0,0,571,45q�6   $��2��6#   ��5.      �� 5/      $ 0.1,0&�6&   $ 0.9,1&�69   .��50      � # �   6#   $ 1Q�6H   � 51      # �  6#   $ 0Q�6F   52      .+�56      �� $
��Left=�6   $	��500��64   $	��Top=�6A   $	��226��6Y   $��	0,0,0,-60q�6e   57      �� 58      -   5         ��Name$ dodajNakitButton��58      #���  6/   #���  6X    	 dodaj#���  6�   $
��Left=�6�   $��
10,264,0,0q�6�   $	��Top=�6�   $	��216��6�   $��20(�6�    J� RenderTransformOrigin$ 0.877,0.624&�6,  $��41��6P  �� 59      -   5        $ AzurirajButton��59      #���  6/   #���  6X    	 azuriraj#��� 	 6�   $
��Left=�6�   $��
10,172,0,0q�6�   $	��Top=�6�   $	��216��6�   $��20(�6  $ 0.516,-0.141&�6  $��41��6T  �� 5:      -   5        $ obrisiButton��5:      #���  6/   #���  6X    
 brisanje#��� 
 6�   $
��Left=�6�   $��
10,218,0,0q�6�   $	��Top=�6�   $	��216��6�   $��41��6  $��20(�6  6  �� 5;      -   5        $ 	MojProfil��5;   +   $��10,310,3,104q�6   #���  6>   #���  6g   $
��Auto��6�   .��5@      � $	��150��6   .+�5B      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�6.   �� 5C      -   5         ��Name$ 	mojprofil��5C       $��Center=�63   $��20(�6P    
 profil#���  6^   5G      5H      � 5I      -   5         �Name$
 boze��5I      $
��Left=�6!   $	��139��6<   $	��Top=�6I   $	��229��6a   ��5J      �� 5K       �� ImageSource$ userrrrr.png��6!   5M      5N      �� 5U   
   -   5        $ LogoutButton��5U   (   $��0,314.8,571,0q�6   #���  6Y   #���  6�   $
��Auto��6�   $��1��6�   .��5V      � $	��150��6    � ColumnDefinitions 5W      �� 5X      $	��59* �6'   �� 5Y      $	��13* �6'   �� 5Z      $��3* �6'   .+�5\        $ Logout=�6*   �� 5]      -	   5        $ logoutTextBlock��5]      $��Center=�65     odjaviSeButton#���  6R   $��35,0,4,-0.4q�6z   $��2��6�   $	��105��6�   5^      5_      5b      5c      
   M S B A M L   `   `   `  ����S  OHCI_PRODAVNICA_NAKITAnew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HCI_PRODAVNICA_NAKITAnewHCI_PRODAVNICA_NAKITAnew  5   	   -    'HCI_PRODAVNICA_NAKITAnew.SettingsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:HCI_PRODAVNICA_NAKITAnew     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
     � Title$  Settings��5
   	   $	��350��6   $
��400 ��6'    � WindowStartupLocation$ CenterScreen=�64    � WindowStyle$
 None=�6Y    � 
ResizeMode$ NoResize=�6l   .��5      � .+�5   
   �� -   5         ��Name$ 
SaveButton��5         	fontColor#���   6&     buttonBackground#���  6O     save#���  6   $
��Left=�6�   $��113,279,0,0q�6�   $	��Top=�6�   $	��148��6�   $��49��6�   $��25(�6   6  �� 5   
   -   5        $ btnExit��5      $��344,10,10,293.4q�5      $y�Visible=�6*    & "MaterialDesignFloatingActionButton#��[ 6@     
fontColor1#���  6|   $
��Auto��5   :   $
��Auto��6H   .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6&     darkSeaGreen#���  64   #���   6b   $��30��6�   $��30��6�   5      �� 5   
   -   5         ��Name$ 
TemeLabela��5        teme#���  6$   $
��Left=�6E   $��	22,47,0,0q�6`   $	��Top=�6s   $��25(�6�   $	��138��6�   $
��Bold"�6�   �� 5   
   -   5        $ JezikLabela��5       	 jezik#���  6%   $
��Left=�6G   $��
202,47,0,0q�6b   $	��Top=�6v   $��25(�6�   $	��137��6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ milana��5      $
��Left=�6%   $	��162��6@   $��
202,97,0,0q�6M   $	��Top=�6a   $	��160��6y   
�������.+�5      	� -   5         	�Name$ SrpskiButton��5      $��0,0,0,0q�60   	 d� 	IsChecked$	 FalseY�6B   #���   6T   #���  6}    
 jezik1#���  6�   $��20(�6�   $��48��6�   6�   	� 5       -   5        $ EngleskiButton��5       $��0,0,0,0q�62   $	 FalseY�6D   #���   6V   #���  6    
	 jezik2#��� 	 6�   $��20(�6�   $��48��6�   6�   5%      �� 5&   
   -   5        $ milaTeme��5&      $
��Left=�6'   $	��162��6B   $��	22,97,0,0q�6O   $	��Top=�6b   $	��150��6z   
�������.+�5'      	� -	   5        $ 
DarkButton��5'      $��0,0,0,0q�6.   $	 FalseY�6@   #���   6R   #���  6{    	
 tema1#��� 
 6�   $��20(�6�   $��48��6�   6�   	� 5(      -
   5        $ LightButton��5(      $��0,0,0,0q�6/   $	 FalseY�6@   #���   6R   #���  6{    	 tema2#���  6�   $��20(�6�   $��48��6�   6�   	� 5)      -   5        $ 
RoseButton��5)      $��0,0,0,0q�6.   $	 FalseY�6@   #���   6R   #���  6{     tem3#���  6�   $��20(�6�   $��48��6�   6�   5+      5-      5.      
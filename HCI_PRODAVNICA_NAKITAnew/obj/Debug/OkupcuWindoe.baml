   M S B A M L   `   `   `  ����S  OHCI_PRODAVNICA_NAKITAnew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HCI_PRODAVNICA_NAKITAnewHCI_PRODAVNICA_NAKITAnew  5   	   +    %HCI_PRODAVNICA_NAKITAnew.OkupcuWindoe   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:HCI_PRODAVNICA_NAKITAnew     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Title$  OkupcuWindoe��5	   	   $	��450��6   $	��800��6+    � 
ResizeMode$ NoResize=�68    � WindowStyle$
 None=�6N   .��5      �  � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $��2 �6   �� 5      $��7* �6   .+�5   
   � $��3��6   $��2��6#   ��5      �� 5       �� 
StartPoint$ 0.1,0&�6&    �� EndPoint$ 0.9,1&�69   .��5      �    
startColor � Color# �   6#    � Offset$ 1Q�6H   � 5        endColor# �  6#   $ 0Q�6F   5      .+�5      �� $	��395��6   $	��Top=�6"    �� CornerRadius$ 0 0 180 180��6:   
�������._�5%      �� -   5        	 ��Name$	 SettingsButton��5%      $
��Left=�61   +  %MaterialDesignThemes.Wpf.ButtonAssist
   CornerRadius$
 10��6L   $��2q�6z     	fontColor#���  6�     buttonBackground#���  6�   $��	22,10,0,0q�6�   $��1��6�   $	��Top=�6  $��81��6  .��5&      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Settings=�6.   5'      5)      5*      � 5+   
   $��0��6   $��Center=�6   
�������$	��236��6M   $��31,82,558,131.6q�6Z   $��3��6s   .+�5,      � $��0��6   $��Center=�6#   .+�5-      ��  �� Orientation$ Vertical=�6   $��20q�64   
�������.+�5.      �� -   5         ��Name$ 
imagePanel��5.   !   $��5q�65   .+�5/      �� $��userrrrr.png��6    $	��211��66   $��	0,0,0.4,0q�6C   50      51      53      55      �� 57   
   -   5         ��Name$ heading��57      $��30(�6%   $
��Bold"�63     
fontColor1#���  6E   $��Kupac��6o   $��Center=�6|   $��2��6�   $��164.8,10,167.6,366q�6�   $	��222��6�   �� 58   
   -   5         ��Name$ txtPersonName��58       $��20(�6   $
��Bold"�67   #���  6I   #���  6r   $��2��6�   $��225.4,92,90,310.6q�6�   �� 59   
   -   5         ��Name$ usernameLabel��59       $��20(�6   $
��Bold"�67     korisnickIme#���  6I   #���  6r   $��2��6�   $��37.4,92,351,310.6q�6�   �� 5:   
   -   5        $ txtPassword��5:       $��20(�6   $
��Bold"�65   #���  6G   #���  6q   $��2��6�   $��225.4,144,90,258.6q�6�   �� 5;   
   -   5        $ PasswordLabel��5;       $��20(�6   $
��Bold"�67     loyinka#���  6I   #���  6m   $��2��6�   $��37.4,144,351,258.6q�6�   �� 5=   
   -   5        $ txtEmail��5=       $��20(�6   $
��Bold"�62   #���  6D   #���  6n   $��2��6�   $��225.4,196,90,206.6q�6�   �� 5>   
   -	   5        $ 
EmailLabel��5>       $��20(�6   $
��Bold"�64    	 email#���  6F   #���  6h   $��2��6�   $��37.4,196,351,206.6q�6�   �� 5?   
   -
   5        $ 
txtBrojtel��5?   !   $��20(�6   $
��Bold"�65   #���  6G   #���  6q   $��2��6�   $��225.4,248,90,154.6q�6�   �� 5@   
   -   5        $ BrojTelLabel��5@       $��20(�6   $
��Bold"�66     brojTel#���  6H   #���  6l   $��2��6�   $��37.4,248,351,153.6q�6�   �� 5G   
   -   5        $	 
EditButton��5G       	 edit#��� 	 6%   $��2��6F   $��338.4,328,127,74.6q�6V   #���  6�   #���  6�   $
��Auto��6�   �� 5H   
   -   5        $	 
SaveButton��5H       
 save#��� 
 6%   $��2��6F   $y�Hidden=�6V   $��225.4,328,240,74.6q�6j   #���  6�   #���  6�   $
��Auto��6�   �� 5L   
   -   5        $	 btnExit��5M   #   $��473.4,10,34,386.6q�5L       & "MaterialDesignFloatingActionButton#��[ 6-   #���  6i    � ToolTip$ Close��5M      $
��Auto��6J   $��2��6X   $
��Auto��6h   .��5N        $ Close=�6&     darkSeaGreen#���  64   #���  6a   $��30��6�   $��30��6�   5P      5S      5U      
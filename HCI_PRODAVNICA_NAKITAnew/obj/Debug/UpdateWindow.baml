   M S B A M L   `   `   `  ����S  OHCI_PRODAVNICA_NAKITAnew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HCI_PRODAVNICA_NAKITAnewHCI_PRODAVNICA_NAKITAnew  5   	   +    %HCI_PRODAVNICA_NAKITAnew.UpdateWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:HCI_PRODAVNICA_NAKITAnew     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Title$  Login��5	   	   $	��414��6   $	��670��6$    � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�6*    � 
ResizeMode$ NoResize=�5      .��5      � $	��414��6   $	��670��6   $	��Top=�6$   .+�5   
   � $��3��6   $��2��6#   ��5      �� 5       �� 
StartPoint$ 0.1,0&�6&    �� EndPoint$ 0.9,1&�69   .��5      �    
startColor � Color# �   6#    � Offset$ 1Q�6H   � 5        endColor# �  6#   $ 0Q�6F   5      .+�5      �� $	��395��6   $	��Top=�6"    �� CornerRadius$ 
0 0 130 10��6:   
�������6T   5      &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 	nakitGrid��5   S   
   AutoGenerateColumns
 .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6C      CanUserDeleteRows . $
��Left=�6   $	��264��6�   $��
153,59,0,0q�6�   $	��Top=�6�   $	��507��6�     	fontColor#���  6    
fontColor1#���  66     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5        headerNayiv,  &System.Windows.Controls.DataGridColumn   Header# �  6%      Width$
 Auto 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Y   �� *naziv+  5         headerCijena# �  6%   $
 Auto 6M    6Z   �� *cijena+  5!        headerGramaza# �  6%   $
 Auto 6N    6[   �� *	gramaza+  5"        headerKolicina# �  6%   $
 Auto 6O    6\   �� *
kolicina+5%      �� 5&   
   -   5         ��Name$ izvrsiButton��5&        potvrdiButton#���  6'   $
��Left=�6Q   $��
13,276,0,0q�6l   $	��Top=�6�   $	��126��6�   $��47��6�   $��20(�6�   #���  6�    	 buttonBackground#��� 	 6   J� RenderTransformOrigin$ 1.421,0.383&�62  �� 5*   
   -   5         ��Name$ novaCijenaLabel��5*      $
��Bold"�6-   $
��Wrap=�6?    
 
novaCijena#��� 
 6S   $
��Left=�6w   $��	13,39,0,0q�6�   #���  6�   $	��Top=�6�   $��20(�6�   $	��126��6�   �� 5+   
   -   5         ��Name$ novaCijenaTextBox��5+      $
��Bold"�6-   $
��Left=�6@   $��37��6\   $��	13,79,0,0q�6h   #���  6|   #���  6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��126��6�   $ 0.445,-0.021&�6  6,  �� 5.   
   -   5        $ novaKolicinaLabel��5.      $
��Bold"�6/   $
��Wrap=�6A     novaKolicina#���  6U   $
��Left=�6{   $��
13,141,0,0q�6�   #���  6�   $	��Top=�6�   $��20(�6�   $	��126��6�   �� 5/   
   -   5        $ novaKolicinaTextBox��5/      $
��Bold"�6/   $
��Left=�6B   $��37��6^   $��
13,199,0,0q�6j   #���  6   #���  6�   $
 Wrap=�6�   $	��Top=�6�   $	��126��6�   $ 0.445,-0.021&�6
  6/  �� 56   
   -   5        $ goBackButton��57   #   $��613,10,10,366q�56       & "MaterialDesignFloatingActionButton#��[ 6)   #���  6e    � ToolTip$ Close��57      $
��Auto��6T   $
��Auto��6b   .��58      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6&     darkSeaGreen#���  64   #���  6a   $��30��6�   $��30��6�   5:      5=      5>      
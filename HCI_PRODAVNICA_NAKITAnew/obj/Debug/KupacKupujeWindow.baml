   M S B A M L   `   `   `  ����S  OHCI_PRODAVNICA_NAKITAnew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HCI_PRODAVNICA_NAKITAnewHCI_PRODAVNICA_NAKITAnew  5   	   0    *HCI_PRODAVNICA_NAKITAnew.KupacKupujeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:HCI_PRODAVNICA_NAKITAnew     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Title$  KupacKupujeWindow��5
   	   $	��450��6#   $	��800��60    � 
ResizeMode$ NoResize=�6<    � WindowStartupLocation$ CenterScreen=�6R    � WindowStyle$
 None=�6w   .��5      � ��5   
   �� 5       �� 
StartPoint$ 0.1,0&�6"    �� EndPoint$ 0.9,1&�65   .��5      �    
startColor � Color# �   6    � Offset$ 1Q�6D   � 5        endColor# �  6   $ 0Q�6B   5      .+�5   
   �� $	��380��6   $	��Top=�6    �� CornerRadius$ 0 0 180 180��66   
�������$��
0,0,-0.4,0q�6i   ._�5      �� -   5        	 ��Name$	 
KupiButton��5        kupi#���  6)     buttonBackground#���  6c     	fontColor#���  6�   $
��Auto��6�   $��434,326,285,20q�6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5        
  Name$
 grid1��5   Q      AutoGenerateColumns .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6A      CanUserDeleteRows . $
��Left=�6y   $	��264��6�   $��
205,57,0,0q�6�   $	��Top=�6�   $	��516��6�   #���  6  #���  6,     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5        headerNayiv,  &System.Windows.Controls.DataGridColumn   Header# �  6%      Width$
 Auto 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Y   �� *naziv+  5        headerCijena# �  6%   $
 Auto 6N    6[   �� *cijena+  5        headerGramaza# �  6%   $
 Auto 6N    6[   �� *	gramaza+  5        headerKolicina# �  6%   $
 Auto 6O    6\   �� *
kolicina+5!      � 5#   
   $��0,0,634.6,0q�6   ��5$      �� 5%      $ 0.1,0&�6&   $ 0.9,1&�69   .��5&      � # �   6#   $ 1Q�6H   � 5'      # �  6#   $ 0Q�6F   5(      .+�5*      �� -   5         ��Name$ pretraziTextBox��5*      $
��Left=�6/   $��23��6J   $��
10,120,0,0q�6V    �� TextWrapping$
 Wrap=�6j   $	��Top=�6~   $	��120��6�   6�   �� 5+      -   5        $	 PretraziButton��5+       	 pretraziPoNazivu#��� 	 6-   $
��Left=�6Z   $��	0,167,0,0q�6�   #���  6�    
 
fontColor1#��� 
 6�   $	��Top=�6�   $	��155��6  $��34��6  5,      �� 5/   
   -   5        $	 btnExit��50   #   $��726,10,23,390.6q�5/       & "MaterialDesignFloatingActionButton#��[ 6+   #��� 
 6g    � ToolTip$ Close��50      $
��Auto��6J   $
��Auto��6X   .��51      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6&     darkSeaGreen#���  64   #���  6a   $��30��6�   $��30��6�   53      57      58      
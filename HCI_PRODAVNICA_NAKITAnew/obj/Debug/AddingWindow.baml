   M S B A M L   `   `   `  ����S  OHCI_PRODAVNICA_NAKITAnew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HCI_PRODAVNICA_NAKITAnewHCI_PRODAVNICA_NAKITAnew  5   	   +    %HCI_PRODAVNICA_NAKITAnew.AddingWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:HCI_PRODAVNICA_NAKITAnew     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
     � Title$  Adding��5
   	   $	��370��6   $	��800��6%    � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�6*    � 
ResizeMode$ NoResize=�5      .��5      � .+�5   
   � $��3��6   $��2��6#   ��5      �� 5       �� 
StartPoint$ 0.1,0&�6&    �� EndPoint$ 0.9,1&�69   .��5      �    
startColor � Color# �   6#    � Offset$ 1Q�6H   � 5        endColor# �  6#   $ 0Q�6F   5      .+�5      �� $	��330��6   $	��Top=�6"    �� CornerRadius$ 0 0 180 180��6:   
�������6U   5      &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 	korpaGrid��5   T   
   AutoGenerateColumns
 .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6A      CanUserDeleteRows . $
��Left=�6�   $	��236��6�   $��
286,35,0,0q�6�   $	��Top=�6�   $	��382��6�     	fontColor#���  6�     buttonBackground#���  6	     Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!        headerNayiv,  &System.Windows.Controls.DataGridColumn   Header# �  6$      Width$
 Auto 6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6X   �� *naziv+  5"        headerCijena# �  6%   $
 Auto 6N    6[   �� *cijena+  5#        headerGramaza# �  6%   $
 Auto 6N    6[   �� *	gramaza+  5$        headerKolicina# �  6%   $
 Auto 6O    6\   �� *
kolicina+5'      �� 5*   
   -   5         ��Name$ dodajUKorpuButton��5*        dodajButton#���  6/   $
��Left=�6W   $��286,286,0,0q�6r   $	��Top=�6�   $	��175��6�    J� RenderTransformOrigin$ 1.189,-0.419&�6�   $��36��6�   $��20(�6�   #���  6�   #���  6  6D  �� 5+   
   -   5        $ potvdiButton��5+       	 potvrdiButton#��� 	 6'   $
��Left=�6Q   $��536,287,0,0q�6l   $	��Top=�6�   $	��132��6�   $��35��6�   $��20(�6�   #���  6�   #���  6  �� 5-   
   -   5        $ goBackButton��5.   #   $��733,10,10,310.6q�5-       &
 "MaterialDesignFloatingActionButton#��[
 6+     
fontColor1#���  6g    � ToolTip$ Close��5.      $
��Auto��6T   $
��Auto��6b   .��5/      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6&     darkSeaGreen#���  64   #���  6a   $��30��6�   $��30��6�   51      � 54   
   $��0,0,543,-0.4q�6   ��55      �� 56      $ 0.1,0&�6&   $ 0.9,1&�69   .��57      � # �   6#   $ 1Q�6H   � 58      # �  6#   $ 0Q�6F   59      .+�5=      �� $
��Left=�6   $	��500��64   $	��Top=�6A   $	��251��6Y   5>      �� 5?      -   5         ��Name$ nazivTextBox��5?      #���  6-   $
��Left=�6V   $��46��6q   $��	33,60,0,0q�6}    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5@      -   5         ��Name$ nazivLabela��5@      #���  6/     nazivLabela#���  6Y   $
��Left=�6�   $��	33,23,0,0q�6�   $	��Top=�6�   $��20(�6�   $	��120��6�   $��32��6�   �� 5A      -   5        $ cijenaLabela��5A      #���  6/     cijenaLabela#���  6Z   $
��Left=�6�   $��
33,106,0,0q�6�   $	��Top=�6�   $��20(�6�   $	��120��6�   �� 5B      -   5        $ cijenaTextBox��5B      #���  6/   $
��Left=�6Y   $��34��6u   $��
33,145,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5C      -	   5        $ gramazaLabel��5C      #���  6/     gramazaLabela#���  6Z   $
��Left=�6�   $��
33,184,0,0q�6�   $	��Top=�6�   $��20(�6�   $	��120��6�   �� 5D      -
   5        $ gramazaTextBox��5D      #���  6/   $
��Left=�6Z   $��34��6u   $��
33,223,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5E      -   5        $ kolicinaLabel��5E      #���  60     kolicinaLabela#���  6Y   $
��Left=�6�   $��
33,262,0,0q�6�   $	��Top=�6�   $��20(�6�   $	��120��6�   �� 5F      -   5        $ kolicinaTextBox��5F      #���  60   $
��Left=�6Y   $��30��6t   $��
33,301,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   5K      �� 5L   
   -   5        $ obrisiStavkuButton��5L        obrisiButton#���  6-   $
��Left=�6V   $	��Top=�6q   $	��106��6�   $��35��6�   $��20(�6�   #���  6�   #���  6�   $��684,123,0,0q�6)  5N      5O      
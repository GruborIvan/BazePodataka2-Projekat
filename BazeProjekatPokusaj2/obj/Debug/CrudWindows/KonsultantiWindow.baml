   M S B A M L   `   `   `  ����O  KBazeProjekatPokusaj2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:BazeProjekatPokusaj2.CrudWindows BazeProjekatPokusaj2.CrudWindows  5   	   8    2BazeProjekatPokusaj2.CrudWindows.KonsultantiWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:BazeProjekatPokusaj2.CrudWindows     5   	     � Title$  KonsultantiWindow��5   	   $	��450��6#   $	��950��60   .��5	      � 
�������.+�5
   
   ��  �� Orientation$ Vertical=�6   $��0,0,-15,-40q�6,   $	��520��6A   $	��Top=�6N   .+�5      �� .��5      � $	��150��6   $��15,10,17,10q�6$    � RowDefinitions 5      �� 5      $��30 �6(   �� 5      $��30 �6(   �� 5      $��30 �6(   �� 5      $��30 �6(   �� 5      $��30 �6(    � ColumnDefinitions 5      �� 5      $	��220 �6+   �� 5      $	��220 �6+   �� 5      $	��66* �6+   �� 5      $
��233* �6+   .+�5      �� $��JMBG Konsultanta: ��6   $
��Left=�69   $��Center=�6U   $��0��6w   $��0��6�    J� RenderTransformOrigin$ 
0.54,0.853&�6�   $	��201��6�   �� 5      -   5         ��Name$ JmbgTextBox��5   ;   $��0��6   $��1��6+   $��	0,0,0,0.4q�6Q   $	��269��6e   $
��Left=�6q   $��2��6�   �� 5      $��Ime: ��6   $
��Left=�6,   $��Center=�6H   $��0��6j   $��1��6z   $��0,0,0,2q�6�   $ 
0.54,0.853&�6�   $	��201��6�   �� 5      -   5        $ 
ImeTextBox��5   ;   $��1��6   $��1��6+   $��0,4.6,0,1.8q�6P   $	��269��6f   $
��Left=�6r   $��2��6�   �� 5!      $��	Prezime: ��6   $
��Left=�60   $��Center=�6L   $��0��6n   $��2��6~   $��0,0,0,2q�6�   $ 
0.54,0.853&�6�   $	��201��6�   �� 5"      -   5        $ PrezimeTextBox��5"   ;   $��2��6   $��1��6+   $��0,3.2,0,2.2q�6T   $	��269��6j   $
��Left=�6v   $��2��6�   �� 5$      $��Radni staz konsultanta: ��6   $
��Left=�6?   $��Center=�6[   $��0��6}   $��3��6�   $	��0,3q�6�   $ 
0.54,0.853&�6�   $	��201��6�   �� 5%      -   5        $ RadniStazTextBox��5%   ;   $��3��6   $��1��6+   $��0,3.2,0,2.2q�6V   $	��269��6l   $
��Left=�6x   $��2��6�   �� 5'      $+��%Vrsta ugovora (trajanje u mesecima): ��6   $
��Left=�6L   $��Center=�6h   $��0��6�   $��4��6�   $��0,2,0,3q�6�   $ 
0.54,0.853&�6�   $	��201��6�   �� 5(      -   5         ��Name$ UgovorComboBox��5(      $��4��67   $��1��6D   $��24,0,0,3q�6T    �� SelectedValuePath$	 UID��6�   $
��Left=�6�    �� DisplayMemberPath$ TrajanjeUgovora��6�   $	��133��6�   ��6f   �� *	Ugovori+6�   �� 5*      -   5        	 ��Name$	 ButtonCancel��5*      $��Cancel��63   $��161.2,5,0,0.4q�6D   $��3��6\   $
��Left=�6l   $��70��6�   $ 1.027,2.872&�6�   �� 5+      -   5        $	 
ButtonSave��5+      $
��Save��61   $ 0.206,0.858&�6@   $��38.2,5,247.2,0q�6d   $��3��6}   $��25��6�   $	��Top=�6�   &   System.Windows.Controls.DataGrid  5.      -   5        
  Name$
 KonsultantiList��5.      
����ح�   SelectionMode$ Single=�6O      
IsReadOnly .    AutoGenerateColumns .  $��0,54,5,-237q�6�   $��4��6�   $��4��6�      Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      -	   5        JMBGKlijenta��,  &System.Windows.Controls.DataGridColumn   Header$ JMBG Developera��50   G      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6`   �� *JMBG+6y     51      -
   5        Ime��$ Ime Developera��51   >   $	 120 6n    6V   �� *Ime+6n     52      -   5        Prezime��$ Prezime Developera��52   B   $	 120 6z    6^   �� *	Prezime+6z     53      -   5        	RadniStaz��$ Radni staz (god.)��53   D   $	 100 6}    6_   �� *	RadniStaz+6}     54      -   5        	TrajanjeU��$ Trajanje ugovora��54   D   $	 120 6�    6^   �� *Ugovor.TrajanjeUgovora+6�   4  .System.Windows.Controls.DataGridTemplateColumn  56      $ 80 65      CellTemplate 57   "   �� 58   &   .R�59   *   �� $	 
ButtonEdit��6@   -   5        $
��EDIT��59   1   6T   5:   '   5<        5=      $ 80 65    5>   "   �� 5?   &   .R�5@   *   �� $	 ButtonDelete��6B   -   5        $��DELETE��5@   1   6X   5A   '   5C      5E      5F      5G      5H      5I      5J      
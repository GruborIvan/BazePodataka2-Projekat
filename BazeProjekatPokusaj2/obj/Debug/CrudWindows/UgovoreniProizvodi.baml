   M S B A M L   `   `   `  ����O  KBazeProjekatPokusaj2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:BazeProjekatPokusaj2.CrudWindows BazeProjekatPokusaj2.CrudWindows  5   	   9    3BazeProjekatPokusaj2.CrudWindows.UgovoreniProizvodi   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:BazeProjekatPokusaj2.CrudWindows     5   	     � Title$  UgovoreniProizvodi��5   	   $	��535��6$   $	��880��61   .��5	      � 
�������.+�5
   
   ��  �� Orientation$ Vertical=�6   .+�5      �� .��5      � $	��200��6   $��15,10,17,10q�6$    � RowDefinitions 5      �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(    � ColumnDefinitions 5      �� 5      $	��220 �6+   �� 5      $	��220 �6+   �� 5      $	��66* �6+   �� 5      $
��233* �6+   .+�5      �� $��	Klijent: ��6   $
��Left=�60   $��Center=�6L   $��0��6n   $��0��6~    J� RenderTransformOrigin$ 
0.54,0.853&�6�   $	��191��6�   $��10,0,0,0q�6�   �� 5      -   5         ��Name$ KlijentComboBox��5      $��1��68   $	��0,5q�6H    �� SelectedValuePath$	 OID��6v   $
��Left=�6�    �� DisplayMemberPath$ NazivKlijenta��6�   $	��259��6�   $��2��6�   ��6U   �� *
Klijenti+6�   �� 5      $��Konsultant: ��6   $
��Left=�63   $��Center=�6O   $��0��6q   $��1��6�   $��10,0,0,2q�6�   $ 
0.54,0.853&�6�   $	��191��6�   �� 5      -   5        $ KonsultantComboBox��5      $��1��6;   $	��0,5q�6K   $	 OID��6|   $
��Left=�6�   $	 Ime��6�   $	��259��6�   $��2��6�   $��1��6�   ��6X   �� *Konsultanti+6�   �� 5!      $��Developer: ��6   $
��Left=�62   $��Center=�6N   $��0��6p   $��2��6�   $��10,0,0,2q�6�   $ 
0.54,0.853&�6�   $	��191��6�   �� 5"      -   5        $ DeveloperiComboBox��5"      $��1��6;   $	��0,5q�6K   $	 OID��6{   $
��Left=�6�   $	 Ime��6�   $	��259��6�   $��2��6�   $��2��6�   ��6X   �� *
Developeri+6�   �� 5$      $��Opis proizvoda: ��6   $
��Left=�67   $��Center=�6S   $��0��6u   $��3��6�   $	��0,3q�6�   $ 
0.54,0.853&�6�   $	��201��6�   �� 5%      -   5         ��Name$ OpisProizvodaTextBox��5%   ;   $��3��6   $��1��6+   $	��0,5q�6Z   $	��269��6h   $
��Left=�6t   $��2��6�   �� 5'      $��Vrednost proizvoda: ��6   $
��Left=�6;   $��Center=�6W   $��0��6y   $��4��6�   $��0,6,0,0q�6�   $ 
0.54,0.853&�6�   $	��201��6�   �� 5(      -   5        $ VrednostProizvodaTextBox��5(   ;   $��4��6   $��1��6+   $	��0,5q�6^   $	��269��6l   $
��Left=�6x   $��2��6�   �� 5*      -   5        	 ��Name$	 ButtonCancel��5*      $��Cancel��63   $��
157,5,0,10q�6D   $��3��6Y   $
��Left=�6i   $��93��6�   6�   �� 5+      -   5        $	 
ButtonSave��5+      $
��Save��61   $ 0.206,0.858&�6@   $��39,5,169,10q�6d   $��3��6z   6�   &   System.Windows.Controls.DataGrid  5-      -   5        
  Name$
 ProizvodiList��5-      
����ح�   SelectionMode$ Single=�6M      
IsReadOnly .    AutoGenerateColumns .  $��0,50,0,-279q�6�   $��4��6�   $��4��6�      Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      -	   5        Klijent��,  &System.Windows.Controls.DataGridColumn   Header$ Ime Klijenta��5/   B      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6X   �� *Klijent.NazivKlijenta+6�     50      -
   5        Prezime��$ Konsultant name��50   B   $	 120 6~    6[   �� *Konsultant.Ime+6~     51      -   5        NazivKlijenta��$ Developer name��51   H   $	 120 6�    6`   �� *Developer.Ime+6�     52      -   5        OpisProizvoda��$ Opis proizvoda��52   H   $	 120 6�    6`   �� *OpisProizvoda+6�     53      -   5        Vrednostproizvoda��$ Vrednost proizvoda��53   L   $	 120 6�    6h   �� *VrednostProizvoda+6�   4  .System.Windows.Controls.DataGridTemplateColumn  54      $ 80 65      CellTemplate 55   "   �� 56   &   .R�57   *   �� $	 
ButtonEdit��6@   -   5        $
��EDIT��57   1   6T   58   '   5:        5;      $ 80 65    5<   "   �� 5=   &   .R�5>   *   �� $	 ButtonDelete��6B   -   5        $��DELETE��5>   1   6X   5?   '   5A      5C      5D      5E      5F      5G      5H      
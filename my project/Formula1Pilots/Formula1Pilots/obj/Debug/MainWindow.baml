   M S B A M L   `   `   `  ����I  EFormula1Pilots, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Formula1PilotsFormula1Pilots  5   	       Formula1Pilots.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Formula1Pilots     5   	     � Title$  Greatest F1 pilots��5   	   $	��450��6$   $	��345��61   .��5	      � $
��Left=�6   $	��400��6&   $��	16,10,0,9q�63   $��Center=�6F   $	��309��6a    � RowDefinitions 5
   
   �� 5      $	��88* �6   �� 5      $	��22* �6   �� 5      $	��11* �6   �� 5      $	��79* �6   .+�5   
   �� -   5         ��Name$ lbNames��5   o   $	��170��6   $	��200��6   $��5,5,0,0q�6+   $
��Left=�6<   $	��Top=�6W   6o   �� 5   
   -   5        $��	Most wins��5      $
��Left=�6%   $��	230,5,0,0q�6@   $	��Top=�6S   $��75��6k   $��20��6v   6�   �� 5   
   -   5        $��Least entries��5      $
��Left=�6)   $��
230,35,0,0q�6D   $	��Top=�6X   $��75��6p   $��20��6{   6�   �� 5   
   -   5         ��Name$ cbDriverStats��5   p   $
��Left=�6   $��20��6.   $��5,34,0,0q�6:   $	��Top=�6L   $	��200��6d   $��2��6�   $��1��6�   �� 5   
   $
��Left=�6   $��5,9,0,0q�6/   $
��Wrap=�6@   $'��!Choose a driver to display stats:��6T   $	��Top=�6}   $��20��6�   $	��200��6�   $��1��6�   �� 5   
   -   5         ��Name$ lbStats��5   ~   $��Stats:��6   $
��Left=�6!   $��5,3,0,0q�6<   $	��Top=�6M   $	��200��6e   $	��145��6q   $��3��6�   �� 5   
   -   5         ��Name$ 	btBetween��5   y   $��Wins 40-90:��6   $
��Left=�6'   $��
230,65,0,0q�6B   $	��Top=�6V   $��75��6n   6�   �� 5   
   -   5        $
 bt98��5   v   $��98 wins:��6   $
��Left=�6$   $��
230,95,0,0q�6?   $	��Top=�6S   $��75��6k   6�   �� 5   
   -   5        $ 
btWinOrder��5   y   $��
Win order:��6   $
��Left=�6&   $��230,125,0,0q�6A   $	��Top=�6V   $��75��6n   6�   5      5      
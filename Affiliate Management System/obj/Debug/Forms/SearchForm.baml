   M S B A M L   `   `   `  ����  Affiliate Management System2    ,Affiliate_Management_System.Forms.SearchForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
SearchForm��5   	   
�������$��432.836��64   $��674.627��6E   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgShow��5         AutoGenerateColumns .  $
��Left=�6X   $��
283,16,0,0q�6s   $	��Top=�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $	��363��6�   $	��365��6�   ��6?   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Referral ID��6E   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Referral_ID+6E     5	      $
 Name��6>    6%   �� *Name+6>     5
      $ Phone��6?    6%   �� *Phone+6?     5      $ Address��6A    6%   �� *	Address+6A     5      $ Email��6@    6%   �� *Email+6@     5      $ Commission Level��6D    6%   �� *
Comm_Level+6D   5      �� 5   
   $��Referral ID:��6   $��Time New Roman)�6'   $��16(�6C   $
��Bold"�6Q   $
��Left=�6c   $��34��6~   $��	10,73,0,0q�6�   $	��Top=�6�   $��99��6�   �� 5   
   $��
Search By:��6   $��Time New Roman)�6%   $��16(�6A   $
��Bold"�6O   $
��Left=�6a   $��34��6|   $��	67,34,0,0q�6�   $	��Top=�6�   $��99��6�   �� 5   
   -   5         ��Name$ txtReferral��5      $
��Left=�6'   $��34��6B   $��
114,68,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��148��6�   �� 5   
   -   5        	 ��Name$	 	btnSearch��5      $��Search��6$   $��20(�65   $
��Bold"�6C   $��Time New Roman)�6U   $
��Left=�6q   $��36��6�   $��150,149,0,0q�6�   $	��Top=�6�   $	��100��6�   6�   �� 5   
   -   5        $	 btnShowAll_��5      $��All Data��6&   $��20(�69   $
��Bold"�6G   $��Time New Roman)�6Y   $
��Left=�6u   $��36��6�   $��150,264,0,0q�6�   $	��Top=�6�   $	��100��6�   6�   �� 5   
   $��To show all Data:��6   $��Time New Roman)�6,   $��16(�6H   $
��Bold"�6V   $
��Left=�6h   $��34��6�   $��
10,264,0,0q�6�   $	��Top=�6�   $	��135��6�   5      5      
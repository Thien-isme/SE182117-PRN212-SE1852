   M S B A M L   `   `   `  ����P  LButtonControl_TongHop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Bai1Bai1  5   	       Bai1.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Bai1     5   	     � Title$  	Tinh Tong��5   	   $	��300��6   $	��210��6(   .��5	      � $
��Left=�6   $	��800��6&    � ColumnDefinitions 5
   
   �� 5      $	��22* �6   �� 5      $	��35* �6   �� 5      $
��103* �6   .+�5   
   �� $��Hệ số a��6   $
��Left=�6"   $��	10,24,0,0q�6=   $	��Top=�6P    J� RenderTransformOrigin$ 0.5,0.5&�6h   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.449Q�6&   T� 5      5      5      �� 5   
   $��Hệ số b
��6   $
��Left=�6,   $��	10,77,0,0q�6G   $	��Top=�6Z   $ 0.495,-0.598&�6r   $��32��6�   �� 5   
   -   5         ��Name$ txtHeSoA��5      $
��Left=�6$   $��	20,54,0,0q�6?    �� TextWrapping$
 Wrap=�6R   $�� ��6f   $	��Top=�6n   $	��140��6�   $��2��6�   
�������6�   �� 5   
   -   5        $ txtHeSoB��5      $
��Left=�6$   $��
20,109,0,0q�6?   $
 Wrap=�6S   $�� ��6g   $	��Top=�6o   $	��140��6�   $��2��6�   �� 5   
   -   5         ��Name$ btnTong��5      $��20,194,22,0q�6"   $	��Top=�67   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $
��20px��6   $*��$pack://siteoforigin:,,,/img/math.png��6%   �� 5       $��33��6   Tong6-   5!      5"      �� 5#   
   -   5        $ btnThoat��5#      $
��Left=�5$      $��106,194,0,0q�6)   $	��Top=�6>   $ 0.554,0.503&�6V   $��2��6z   .��5&      �� $ 
Horizontal=�6   .+�5'      �� $
��20px��6   $+��%pack://siteoforigin:,,,/img/close.png��6%   �� 5(      Thoat6#   5)      5+      �� 5.   
   $��Kết quả��6   $
��Left=�6"   $��
20,132,0,0q�6=   $	��Top=�6Q   $��27��6i   �� 5/   
   -   5         ��Name$ 	lblKetQua��5/      $�� ��6#   $
��Left=�6.   $��
20,159,0,0q�6I   $	��Top=�6]   $	��140��6u   $��25��6�   $��2��6�   ���	#FFF3FF006�   51      52      
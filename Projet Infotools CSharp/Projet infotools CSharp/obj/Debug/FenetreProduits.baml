   M S B A M L   `   `   `  ����R  NProjet infotools CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Projet_infotools_CSharpProjet_infotools_CSharp  5   	   -    'Projet_infotools_CSharp.FenetreProduits   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Projet_infotools_CSharp     5   	     � Title$  FenêtreProduits��5   	   $	��450��6!   $	��800��6.   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
DtgProduit��5
         AutoGenerateColumns .  $��	0,147,0,0q�6[   ��6'   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Numéro��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	NumProd+  5      $	 Nom��6%    62   �� *	NomProd+  5      $
 Prix��6%    63   �� *Prix+5      �� 5   
   -   5         ��Name$ 
TxtNomProd��5      $
��Left=�6&   $��23��6A    �� TextWrapping$
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��120��6�   $��
153,83,0,0q�6�   �� 5   
   -   5        $ TxtPrixProd��5      $
��Left=�6'   $��23��6B   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��120��6�   $��
319,83,0,0q�6�   �� 5   
   -   5         ��Name$ BtnAjouterProd��5      $��Ajouter produit��6)   $
��Left=�6C   $	��Top=�6^   $	��115��6v   $��
648,10,0,0q�6�   $��34��6�   �� 5   
   -   5        $ BtnModifierProd��5      $��Modifier produit��6*   $
��Left=�6E   $	��Top=�6`   $	��115��6x   $��
648,49,0,0q�6�   $��34��6�   6�   �� 5   
   -   5        $ BtnSupprimerProd��5      $��Supprimer produit��6+   $
��Left=�6G   $	��Top=�6b   $	��115��6z   $��
648,88,0,0q�6�   $��34��6�   6�   �� 5   
   $	��Nom��6   $
��Left=�6   $	��Top=�69   $��
153,49,0,0q�6Q   �� 5   
   $
��Prix��6   $
��Left=�6   $	��Top=�6:   $��
319,49,0,0q�6R   5      5      
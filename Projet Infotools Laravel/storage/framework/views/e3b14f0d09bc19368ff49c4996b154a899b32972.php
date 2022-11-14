

<?php $__env->startSection('content'); ?>
    <div class="pull-right">
        <a class="btn btn-primary" href="<?php echo e(route('clients.index')); ?>"> Back</a>
    </div>
    <!-- table produits acheté -->
    <h3>Produits commandés par le client N°<?php echo e($client->id); ?> : <?php echo e($client->nomCli . " " .  $client->prenomCli); ?></h3>
    <table class="table table-bordered">
        <tr>
            <th>Numéro Produit</th>
            <th>Nom Produit</th>
            <th>Quantité Produit</th>
        </tr>

        <!-- on parcourt la liste commandes donné en paramètre
        les crochets servent à remplacer la balise php -->

    <?php $__currentLoopData = $commandes; $__env->addLoop($__currentLoopData); foreach($__currentLoopData as $commande): $__env->incrementLoopIndices(); $loop = $__env->getLastLoop(); ?>
        <?php $__currentLoopData = $commande->produits; $__env->addLoop($__currentLoopData); foreach($__currentLoopData as $produit): $__env->incrementLoopIndices(); $loop = $__env->getLastLoop(); ?>
        <tr>
            <td><?php echo e($produit->id); ?></td>
            <td><?php echo e($produit->libProd); ?></td>
            <td><?php echo e($produit->pivot->qte); ?></td>
        </tr>
        <?php endforeach; $__env->popLoop(); $loop = $__env->getLastLoop(); ?>
    <?php endforeach; $__env->popLoop(); $loop = $__env->getLastLoop(); ?>
    </table>
<?php $__env->stopSection(); ?>
<?php echo $__env->make('layout', \Illuminate\Support\Arr::except(get_defined_vars(), ['__data', '__path']))->render(); ?><?php /**PATH C:\Users\alexa\source\repos\InfoTool2\resources\views/clients/show.blade.php ENDPATH**/ ?>
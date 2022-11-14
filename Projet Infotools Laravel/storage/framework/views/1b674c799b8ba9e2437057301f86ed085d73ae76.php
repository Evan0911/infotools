

<?php $__env->startSection('content'); ?>
    <?php if(Auth::user()->is_admin == 0): ?>
        <div class="row">
            <div class="col-lg-12 margin-tb">
                <div class="pull-left">
                    <h2>Produit</h2>
                </div>
            </div>
        </div>

        <!-- si on reçoit un paramètre succès on affiche un message de succès -->
        <?php if($message = Session::get('success')): ?>
            <div class="alert alert-success">
                <p><?php echo e($message); ?></p>
            </div>
        <?php endif; ?>

        <table class="table table-bordered">
            <tr>
                <th>No</th>
                <th>Libellé</th>
                <th>Prix</th>
            </tr>

            <!-- on parcourt la liste produits donné en paramètre
            les crochets servent à remplacer la balise php -->
        <?php $__currentLoopData = $produits; $__env->addLoop($__currentLoopData); foreach($__currentLoopData as $produit): $__env->incrementLoopIndices(); $loop = $__env->getLastLoop(); ?>
        <tr>
            <td><?php echo e(++$i); ?></td>
            <td><?php echo e($produit->libProd); ?></td>
            <td><?php echo e($produit->prixProd . " "); ?></td>
        </tr>
        <?php endforeach; $__env->popLoop(); $loop = $__env->getLastLoop(); ?>
        </table>

        <!-- seulement si paginate !!!-->
        <?php echo $produits->links(); ?>

    <?php else: ?>
        <div class="row">
            <div class="col-lg-12 margin-tb">
                <div class="pull-left">
                    <h2>Produit</h2>
                </div>
                <div class="pull-right">
                <!-- un bouton appel la page produits.create -->
                    <a class="btn btn-success" href="<?php echo e(route('produits.create')); ?>"> Create New produit</a>
                </div>
            </div>
        </div>

        <!-- si on reçoit un paramètre succès on affiche un message de succès -->
        <?php if($message = Session::get('success')): ?>
            <div class="alert alert-success">
                <p><?php echo e($message); ?></p>
            </div>
        <?php endif; ?>

        <table class="table table-bordered">
            <tr>
                <th>No</th>
                <th>Libellé</th>
                <th>Prix</th>
                <th width="280px">Action</th>
            </tr>

            <!-- on parcourt la liste produits donné en paramètre
            les crochets servent à remplacer la balise php -->
        <?php $__currentLoopData = $produits; $__env->addLoop($__currentLoopData); foreach($__currentLoopData as $produit): $__env->incrementLoopIndices(); $loop = $__env->getLastLoop(); ?>
        <tr>
            <td><?php echo e(++$i); ?></td>
            <td><?php echo e($produit->libProd); ?></td>
            <td><?php echo e($produit->prixProd . " "); ?></td>
            <td>
                <!--<a class="btn btn-info" href="<?php echo e(route('produits.show',$produit->id)); ?>">Show</a>-->
                <a class="btn btn-primary" href="<?php echo e(route('produits.edit',$produit->id)); ?>">Edit</a>
                <!-- on ouvre un formulaire qui, avec le bouton, supprime le produit -->
                <?php echo Form::open(['method' => 'DELETE','route' => ['produits.destroy', $produit->id],'style'=>'display:inline']); ?>

                <?php echo Form::submit('Delete', ['class' => 'btn btn-danger']); ?>

                <?php echo Form::close(); ?>

            </td>
        </tr>
        <?php endforeach; $__env->popLoop(); $loop = $__env->getLastLoop(); ?>
        </table>

        <!-- seulement si paginate !!!-->
        <?php echo $produits->links(); ?>

    <?php endif; ?>
<?php $__env->stopSection(); ?>
<?php echo $__env->make('layout', \Illuminate\Support\Arr::except(get_defined_vars(), ['__data', '__path']))->render(); ?><?php /**PATH C:\Users\alexa\source\repos\InfoTools\resources\views/produits/index.blade.php ENDPATH**/ ?>
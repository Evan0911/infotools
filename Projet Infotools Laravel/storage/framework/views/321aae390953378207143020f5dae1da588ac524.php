<?php $__env->startSection('content'); ?>
    <div class="row">
        <div class="col-lg-12 margin-tb">
            <div class="pull-left">
                <h2>Add New RDV</h2>
            </div>
            <div class="pull-right">
                <a class="btn btn-primary" href="<?php echo e(route('clients.index')); ?>"> Back</a>
            </div>
        </div>
    </div>
<!-- si on a des erreurs on nous les affiche -->
    <?php if(count($errors) < 0): ?>
        <div class="alert alert-danger">
            <strong>Whoops!</strong> There were some problems with your input.<br><br>
            <ul>
                <?php $__currentLoopData = $errors->all(); $__env->addLoop($__currentLoopData); foreach($__currentLoopData as $error): $__env->incrementLoopIndices(); $loop = $__env->getLastLoop(); ?>
                    <li><?php echo e($error); ?></li>
                <?php endforeach; $__env->popLoop(); $loop = $__env->getLastLoop(); ?>
            </ul>
        </div>
    <?php endif; ?>
    <!-- on appelle un formulaire avec comme destination clients.store et en method post -->
    <form method="POST" action="<?php echo e(route('rdvs.store')); ?>" style ="display:inline">
        <?php echo csrf_field(); ?>
        <?php echo $__env->make('rdvs.form', \Illuminate\Support\Arr::except(get_defined_vars(), ['__data', '__path']))->render(); ?>
    </form>
<?php $__env->stopSection(); ?>

<?php echo $__env->make('layout', \Illuminate\Support\Arr::except(get_defined_vars(), ['__data', '__path']))->render(); ?><?php /**PATH C:\Users\alexa\source\repos\InfoTool2\resources\views/rdvs/create.blade.php ENDPATH**/ ?>
<?php $__env->startSection('content'); ?>
<!-- partie prospect -->

        <div class="row">
            <div class="col-lg-12 margin-tb">
                <div class="pull-right">
                <!-- un bouton appel la page clients.create -->
                    <a class="btn btn-success" href="<?php echo e(route('rdvs.create')); ?>"> Create New RDV</a>
                </div>
            </div>
        </div>

        <!-- si on reçoit un paramètre succès on affiche un message de succès -->
        <?php if($message = Session::get('success')): ?>
            <div class="alert alert-success">
                <p><?php echo e($message); ?></p>
            </div>
        <?php endif; ?>

        <!-- table RDV -->
        <h3> Table RDV </h3>
        <table class="table table-bordered">
            <tr>
            <th>Numéro RDV</th>
                    <th>Nom client</th>
                    <th>Nom prospect</th>
                    <th>Date RDV</th>
                <th width="280px">Action</th>
            </tr>

            <!-- on parcourt la liste clients donné en paramètre
            les crochets servent à remplacer la balise php -->
        <?php $__currentLoopData = $rdvs; $__env->addLoop($__currentLoopData); foreach($__currentLoopData as $rdv): $__env->incrementLoopIndices(); $loop = $__env->getLastLoop(); ?>
        <tr>
            <td><?php echo e($rdv->id); ?></td>
            <td><?php echo e($rdv->client->nomCli . " " . $rdv->client->prenomCli); ?></td>
            <td><?php echo e($rdv->prospect->nomPros . " " . $rdv->prospect->prenomPros); ?></td>
            <td><?php echo e(date("d/m/Y H:i:s", strtotime($rdv->dateRdv))); ?></td>
            <td>
                <a class="btn btn-info" href="<?php echo e(route('rdvs.show',$rdv->id)); ?>">Show</a>
                <a class="btn btn-primary" href="<?php echo e(route('rdvs.edit',$rdv->id)); ?>">Edit</a>
                <form method= "DELETE" route="[rdvs.destroy,$rdv->id]" style ="display:inline">
                <?php echo csrf_field(); ?>
                    <a class="btn btn-primary" href="<?php echo e(route('rdvs.edit',$rdv->id)); ?>">Supprimer</a>
                </form>
                <!-- on ouvre un formulaire qui, avec le bouton, supprime le client -->

            </td>
        </tr>
        <?php endforeach; $__env->popLoop(); $loop = $__env->getLastLoop(); ?>
        </table>

        <div class="row">
            <div class="col-lg-12 margin-tb">
                <div class="pull-right">
                <!-- un bouton appel la page clients.create -->
                    <a class="btn btn-success" href="<?php echo e(route('clients.create')); ?>"> Create New Client</a>
                </div>
            </div>
        </div>


        <!-- table CLIENT -->
        <h3>Table Clients</h3>
        <table class="table table-bordered">
            <tr>
                <th>Numéro Client</th>
                <th>Nom</th>
                <th>Adresse</th>
                <th>Téléphone</th>
                <th>Mail</th>
                <th width="280px">Action</th>
            </tr>

            <!-- on parcourt la liste clients donné en paramètre
            les crochets servent à remplacer la balise php -->
        <?php $__currentLoopData = $clients; $__env->addLoop($__currentLoopData); foreach($__currentLoopData as $client): $__env->incrementLoopIndices(); $loop = $__env->getLastLoop(); ?>
        <tr>
            <td><?php echo e($client->id); ?></td>
            <td><?php echo e($client->nomCli . " " . $client->prenomCli); ?></td>
            <td><?php echo e($client->adresseCli . " " . $client->cpCli . " " . $client->villeCli); ?></td>
            <td><?php echo e($client->telCli); ?></td>
            <td><?php echo e($client->mailCli); ?></td>
            <td>
                <a class="btn btn-info" href="<?php echo e(route('clients.show',$client->id)); ?>">Show</a>
                <a class="btn btn-primary" href="<?php echo e(route('clients.edit',$client->id)); ?>">Edit</a>
                <!-- on ouvre un formulaire qui, avec le bouton, supprime le client -->

            </td>
        </tr>
        <?php endforeach; $__env->popLoop(); $loop = $__env->getLastLoop(); ?>
        </table>

        <?php echo $clients->links(); ?>

<?php $__env->stopSection(); ?>

<?php echo $__env->make('layout', \Illuminate\Support\Arr::except(get_defined_vars(), ['__data', '__path']))->render(); ?><?php /**PATH C:\Users\alexa\source\repos\InfoTool2\resources\views/clients/index.blade.php ENDPATH**/ ?>